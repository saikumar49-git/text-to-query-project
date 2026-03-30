using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RefreshToken1
{
    public int Id { get; set; }

    public int UserId { get; set; }

    public string Token { get; set; } = null!;

    public string? JwtId { get; set; }

    public bool IsActive { get; set; }

    public bool IsRevoked { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime ExpiresAt { get; set; }

    public DateTime? RevokedAt { get; set; }

    public string? RevokedByIp { get; set; }

    public string? CreatedByIp { get; set; }

    public virtual User3 User { get; set; } = null!;
}
