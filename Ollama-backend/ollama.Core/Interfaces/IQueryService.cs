using ollama.common.Models;

namespace ollama.Core.Interfaces;

public interface IQueryService
{
    Task<QueryResponse> ProcessNaturalLanguageQueryAsync(QueryRequest request, CancellationToken cancellationToken = default);
}
