namespace ollama.Core.Interfaces;

public interface ISchemaExtractionService
{
    Task<string> GetDatabaseSchemaAsync();
}
