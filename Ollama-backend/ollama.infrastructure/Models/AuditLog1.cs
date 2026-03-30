using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AuditLog1
{
    public int Id { get; set; }

    public int? UserId { get; set; }

    public string Action { get; set; } = null!;

    public string? Description { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual User3? User { get; set; }
}
