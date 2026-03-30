using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class User3
{
    public int Id { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? FullName { get; set; }

    public string? PasswordHash { get; set; }

    public string? PasswordSalt { get; set; }

    public bool IsActive { get; set; }

    public bool IsEmailVerified { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public DateTime? LastLoginAt { get; set; }

    public string? AuthProvider { get; set; }

    public string? ExternalProviderId { get; set; }

    public string? ProfilePictureUrl { get; set; }

    public virtual ICollection<AuditLog1> AuditLog1s { get; set; } = new List<AuditLog1>();

    public virtual ICollection<RefreshToken1> RefreshToken1s { get; set; } = new List<RefreshToken1>();

    public virtual ICollection<UserRole2> UserRole2s { get; set; } = new List<UserRole2>();
}
