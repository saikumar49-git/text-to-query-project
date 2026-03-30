using System.ComponentModel.DataAnnotations;

namespace ollama.common.Models;

public class QueryRequest
{
    [Required]
    [MaxLength(500, ErrorMessage = "Query length must not exceed 500 characters to prevent prompt injection issues.")]
    public string Query { get; set; } = string.Empty;
}
