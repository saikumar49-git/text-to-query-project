namespace ollama.Core.Interfaces;

public interface ISqlValidatorService
{
    bool IsSafeQuery(string sql);
}
