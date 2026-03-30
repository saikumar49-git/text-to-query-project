using System.Text.RegularExpressions;
using ollama.Core.Interfaces;

namespace ollama.infrastructure.Services;

public class SqlValidatorService : ISqlValidatorService
{
    public bool IsSafeQuery(string sql)
    {
        if (string.IsNullOrWhiteSpace(sql)) return false;

        sql = sql.Trim().ToLower();

        if (!sql.StartsWith("select")) return false;

        // Block multiple statements
        if (sql.Contains(";")) return false;

        var forbidden = new[]
        {
        "drop", "delete", "update", "insert",
        "alter", "truncate", "exec"
    };

        return !forbidden.Any(f => sql.Contains(f));
    }
}