namespace ollama.Core.Interfaces;

public interface IOllamaService
{
    Task<string> GenerateSqlAsync(string prompt, string schema = "", CancellationToken cancellationToken = default);
    Task<string> FixSqlAsync(string sqlQuery, string errorMessage, CancellationToken cancellationToken = default);
}
