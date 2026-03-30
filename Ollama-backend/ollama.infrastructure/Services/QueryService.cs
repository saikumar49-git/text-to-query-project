using Microsoft.Extensions.Logging;
using ollama.Core.Interfaces;
using ollama.common.Models;

namespace ollama.infrastructure.Services;

public class QueryService : IQueryService
{
    private readonly IOllamaService _ollamaService;
    private readonly ISqlValidatorService _sqlValidatorService;
    private readonly ISqlExecutionService _sqlExecutionService;
    private readonly ISchemaExtractionService _schemaExtractionService;
    private readonly ILogger<QueryService> _logger;

    public QueryService(
        IOllamaService ollamaService, 
        ISqlValidatorService sqlValidatorService, 
        ISqlExecutionService sqlExecutionService,
        ISchemaExtractionService schemaExtractionService,
        ILogger<QueryService> logger)
    {
        _ollamaService = ollamaService;
        _sqlValidatorService = sqlValidatorService;
        _sqlExecutionService = sqlExecutionService;
        _schemaExtractionService = schemaExtractionService;
        _logger = logger;
    }

    public async Task<QueryResponse> ProcessNaturalLanguageQueryAsync(QueryRequest request, CancellationToken cancellationToken = default)
    {
        if (request == null || string.IsNullOrWhiteSpace(request.Query))
        {
            return new QueryResponse { IsSuccess = false, Error = "Query cannot be empty." };
        }

        try
        {
            // Dynamically load schema from DB
            _logger.LogInformation("Extracting database schema...");
            var schema = await _schemaExtractionService.GetDatabaseSchemaAsync(); 

            // 1. Generate SQL using Ollama
            _logger.LogInformation("Generating SQL for request: {Request}", request.Query);
            var sqlQuery = await _ollamaService.GenerateSqlAsync(request.Query, schema, cancellationToken);
            
            if (string.IsNullOrWhiteSpace(sqlQuery) || sqlQuery == "INVALID_QUERY")
            {
                return new QueryResponse { IsSuccess = false, Error = "Failed to generate a valid SQL query from your request." };
            }

            // 2. Validate SQL query
            if (!_sqlValidatorService.IsSafeQuery(sqlQuery))
            {
                _logger.LogWarning("Unsafe query rejected: {Query}", sqlQuery);
                return new QueryResponse { SqlQuery = sqlQuery, IsSuccess = false, Error = "Generated query is unsafe. Only SELECT queries are permitted." };
            }

            // 3. Execute SQL using ISqlExecutionService
            _logger.LogInformation("Executing safe SQL query.");
            List<Dictionary<string, object>> data;
            
            try
            {
                data = await _sqlExecutionService.ExecuteDynamicQueryAsync(sqlQuery);
            }
            catch (Exception ex)
            {
                _logger.LogWarning(ex, "Initial SQL execution failed. Attempting to auto-fix using LLM...");
                
                // 4. Attempt to auto-fix the query
                var fixedSqlQuery = await _ollamaService.FixSqlAsync(sqlQuery, ex.Message, cancellationToken);
                
                if (string.IsNullOrWhiteSpace(fixedSqlQuery) || fixedSqlQuery == "INVALID_QUERY")
                {
                    return new QueryResponse { IsSuccess = false, Error = "Initial execution failed and automated fix could not resolve the query." };
                }

                if (!_sqlValidatorService.IsSafeQuery(fixedSqlQuery))
                {
                    return new QueryResponse { SqlQuery = fixedSqlQuery, IsSuccess = false, Error = "The auto-fixed query is unsafe. Only SELECT queries are permitted." };
                }

                _logger.LogInformation("Executing fixed safe SQL query.");
                sqlQuery = fixedSqlQuery; // return the successfully fixed query to the caller
                data = await _sqlExecutionService.ExecuteDynamicQueryAsync(fixedSqlQuery); // Execute the fixed query
            }

            return new QueryResponse
            {
                SqlQuery = sqlQuery,
                Data = data,
                IsSuccess = true,
                Error = null
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error processing natural language query");
            return new QueryResponse { IsSuccess = false, Error = $"An error occurred during DB execution: {ex.Message}" };
        }
    }
}
