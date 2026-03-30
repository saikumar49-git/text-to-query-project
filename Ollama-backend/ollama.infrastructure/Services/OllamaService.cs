using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;
using ollama.Core.Interfaces;

namespace ollama.infrastructure.Services;

public class OllamaService : IOllamaService
{
    private readonly HttpClient _httpClient;
    private readonly ILogger<OllamaService> _logger;
    private const string OllamaEndpoint = "v1/chat/completions";
    private const string ModelName = "llama3.2:latest";

    public OllamaService(HttpClient httpClient, ILogger<OllamaService> logger)
    {
        _httpClient = httpClient ?? throw new ArgumentNullException(nameof(httpClient));
        _logger = logger ?? throw new ArgumentNullException(nameof(logger));
        
        if (_httpClient.BaseAddress == null)
        {
            _httpClient.BaseAddress = new Uri("http://localhost:11434/");
        }
        
        _httpClient.Timeout = TimeSpan.FromMinutes(2);
    }

    public async Task<string> GenerateSqlAsync(string prompt, string schema = "", CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(prompt))
            throw new ArgumentException("Prompt cannot be empty.", nameof(prompt));
        var fullPrompt = $@"
You are a SQL Server expert.

STRICT RULES:
- Only SELECT queries
- No INSERT, UPDATE, DELETE
- No explanation
- No markdown
- Use ONLY given table
- Use TOP (100)
- If unsure return: INVALID_QUERY

Database Schema:
{schema}

User Request:
{prompt}

Return ONLY SQL query.
";
        //        var fullPrompt = $@"You are a SQL Server expert.

        //Convert natural language into SQL query.

        //Rules:
        //- Only SELECT queries allowed
        //- No INSERT, UPDATE, DELETE
        //- Use TOP (100)
        //- Avoid SELECT *
        //- Return only SQL query

        //Database Schema:
        //{schema}

        //User Request:
        //""{prompt}""";

        return await SendToOllamaAsync(fullPrompt, cancellationToken);
    }

    public async Task<string> FixSqlAsync(string sqlQuery, string errorMessage, CancellationToken cancellationToken = default)
    {
        if (string.IsNullOrWhiteSpace(sqlQuery))
            throw new ArgumentException("Original query cannot be empty.", nameof(sqlQuery));

        var fullPrompt = $@"The SQL query failed:

{sqlQuery}

Error:
{errorMessage}

Fix and return only SQL query.";

        _logger.LogInformation("Requesting Ollama to fix a bad SQL Query.");
        return await SendToOllamaAsync(fullPrompt, cancellationToken);
    }

    private async Task<string> SendToOllamaAsync(string fullPrompt, CancellationToken cancellationToken)
    {
        var requestBody = new
        {
            model = "llama3.2:latest",
            messages = new[]
            {
            new { role = "user", content = fullPrompt }
        },
            temperature = 0
        };

        var response = await _httpClient.PostAsJsonAsync("v1/chat/completions", requestBody, cancellationToken);

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<JsonElement>();

        var sql = result
            .GetProperty("choices")[0]
            .GetProperty("message")
            .GetProperty("content")
            .GetString();

        return CleanSqlString(sql!);
    }
    private static string CleanSqlString(string input)
    {
        var cleaned = input.Trim();
        if (cleaned.StartsWith("```sql", StringComparison.OrdinalIgnoreCase))
        {
            cleaned = cleaned.Substring(6);
        }
        else if (cleaned.StartsWith("```", StringComparison.OrdinalIgnoreCase))
        {
            cleaned = cleaned.Substring(3);
        }
        
        if (cleaned.EndsWith("```", StringComparison.OrdinalIgnoreCase))
        {
            cleaned = cleaned.Substring(0, cleaned.Length - 3);
        }
        
        return cleaned.Trim();
    }

    private class OllamaRequest
    {
        [JsonPropertyName("model")]
        public string Model { get; set; } = string.Empty;

        [JsonPropertyName("prompt")]
        public string Prompt { get; set; } = string.Empty;

        [JsonPropertyName("stream")]
        public bool Stream { get; set; }
    }

    private class OllamaResponse
    {
        [JsonPropertyName("response")]
        public string Response { get; set; } = string.Empty;
        
        [JsonPropertyName("done")]
        public bool Done { get; set; }
    }
}
