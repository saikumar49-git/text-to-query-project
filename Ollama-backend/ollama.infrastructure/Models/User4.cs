using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class User4
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public int RoleId { get; set; }

    public string? Department { get; set; }

    public string? JobTitle { get; set; }

    public string? AvatarUrl { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime UpdatedAt { get; set; }

    public DateTime? LastLoginAt { get; set; }

    public virtual ICollection<AuditLog2> AuditLog2s { get; set; } = new List<AuditLog2>();

    public virtual ICollection<Notification> Notifications { get; set; } = new List<Notification>();

    public virtual ICollection<RefreshToken2> RefreshToken2s { get; set; } = new List<RefreshToken2>();

    public virtual Role3 Role { get; set; } = null!;
}
