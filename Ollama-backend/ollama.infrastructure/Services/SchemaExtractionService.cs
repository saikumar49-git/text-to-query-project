using System.Data;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ollama.Core.Interfaces;
using ollama.infrastructure.DBContext;

namespace ollama.infrastructure.Services;

public class SchemaExtractionService : ISchemaExtractionService
{
    private readonly EPPPSDBContext _dbContext;

    public SchemaExtractionService(EPPPSDBContext dbContext)
    {
        _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));
    }
    public async Task<string> GetDatabaseSchemaAsync()
    {
        return @"
Table: LASBCAAuthorizationCommence (
    AuthorizationCommenceId,
    ApplicationNumber,
    AuthorizationStatus,
    CreatedOn,
    UpdatedOn,
    IsProcessCompleted,
    PermitNumber,
    PolicyNumber,
    ProjectTitle
)";
    }
    //public async Task<string> GetDatabaseSchemaAsync()
    //{
    //    var sql = @"
    //        SELECT TABLE_NAME, COLUMN_NAME 
    //        FROM INFORMATION_SCHEMA.COLUMNS 
    //        WHERE TABLE_SCHEMA = 'dbo' 
    //        ORDER BY TABLE_NAME, ORDINAL_POSITION;";

    //    using var command = _dbContext.Database.GetDbConnection().CreateCommand();
    //    command.CommandText = sql;
    //    command.CommandType = CommandType.Text;

    //    if (command.Connection!.State != ConnectionState.Open)
    //    {
    //        await command.Connection.OpenAsync();
    //    }

    //    using var reader = await command.ExecuteReaderAsync();

    //    var tableDictionary = new Dictionary<string, List<string>>();

    //    while (await reader.ReadAsync())
    //    {
    //        var tableName = reader.GetString(0);
    //        var colName = reader.GetString(1);

    //        if (!tableDictionary.ContainsKey(tableName))
    //        {
    //            tableDictionary[tableName] = new List<string>();
    //        }

    //        tableDictionary[tableName].Add(colName);
    //    }

    //    var sb = new StringBuilder();
    //    foreach (var kvp in tableDictionary)
    //    {
    //        sb.AppendLine($"Table: {kvp.Key} ({string.Join(", ", kvp.Value)})");
    //    }

    //    return sb.ToString().TrimEnd();
    //}
}
