namespace ollama.Core.Interfaces;

public interface ISqlExecutionService
{
    Task<List<Dictionary<string, object>>> ExecuteDynamicQueryAsync(string sql);
}
