using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class User2
{
    public int UserId { get; set; }

    public string UserName { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string PasswordHash { get; set; } = null!;

    public DateTime CreatedAt { get; set; }

    public bool IsActive { get; set; }

    public virtual ICollection<FileAccessLog> FileAccessLogs { get; set; } = new List<FileAccessLog>();

    public virtual ICollection<FileMetadatum> FileMetadata { get; set; } = new List<FileMetadatum>();

    public virtual ICollection<FileShare> FileShareSharedByUsers { get; set; } = new List<FileShare>();

    public virtual ICollection<FileShare> FileShareSharedWithUsers { get; set; } = new List<FileShare>();
}
