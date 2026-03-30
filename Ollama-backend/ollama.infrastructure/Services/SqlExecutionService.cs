using System.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using ollama.Core.Interfaces;
using ollama.infrastructure.DBContext;

namespace ollama.infrastructure.Services;

public class SqlExecutionService : ISqlExecutionService
{
    private readonly EPPPSDBContext _dbContext;
    private readonly ILogger<SqlExecutionService> _logger;

    public SqlExecutionService(EPPPSDBContext dbContext, ILogger<SqlExecutionService> logger)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
    }

    public async Task<List<Dictionary<string, object>>> ExecuteDynamicQueryAsync(string sql)
    {
        _logger.LogInformation("Executing RAW SQL Database Query: {Sql}", sql);

        using var command = _dbContext.Database.GetDbConnection().CreateCommand();
        command.CommandText = sql;
        command.CommandType = CommandType.Text;
        
        // Ensure malicious long-running queries do not tie up connection pool
        command.CommandTimeout = 30; // 30 second timeout

        if (command.Connection!.State != ConnectionState.Open)
        {
            await command.Connection.OpenAsync();
        }

        using var result = await command.ExecuteReaderAsync();
        var dataList = new List<Dictionary<string, object>>();

        int rowCount = 0;
        const int MaxRows = 100;
        
        while (await result.ReadAsync() && rowCount < MaxRows) // Hard safety limit at 100 results
        {
            var row = new Dictionary<string, object>();
            for (var column = 0; column < result.FieldCount; column++)
            {
                var columnName = result.GetName(column);
                var value = result.IsDBNull(column) ? null : result.GetValue(column);
                
                int i = 1;
                var finalColumnName = columnName;
                while (row.ContainsKey(finalColumnName))
                {
                    finalColumnName = $"{columnName}_{i++}";
                }
                
                row.Add(finalColumnName, value!);
            }
            dataList.Add(row);
            rowCount++;
        }

        if (rowCount >= MaxRows)
        {
            _logger.LogWarning("Query returned {RowCount} or more rows. Results explicitly truncated for safety.", rowCount);
        }

        return dataList;
    }
}
