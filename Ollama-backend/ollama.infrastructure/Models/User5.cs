using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class User5
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public string Salt { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string FullName { get; set; } = null!;

    public bool IsActive { get; set; }

    public bool IsLocked { get; set; }

    public int FailedLoginAttempts { get; set; }

    public DateTime? LockoutEnd { get; set; }

    public DateTime? LastLoginAt { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public string? PhoneNumber { get; set; }

    public virtual ICollection<RefreshToken3> RefreshToken3s { get; set; } = new List<RefreshToken3>();

    public virtual ICollection<UserActivity> UserActivities { get; set; } = new List<UserActivity>();
}
