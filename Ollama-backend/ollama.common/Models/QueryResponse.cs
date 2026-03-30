namespace ollama.common.Models;

public class QueryResponse
{
    public string SqlQuery { get; set; } = string.Empty;
    public object Data { get; set; } = Array.Empty<object>();
    public bool IsSuccess { get; set; }
    public string Error { get; set; } = string.Empty;
}
