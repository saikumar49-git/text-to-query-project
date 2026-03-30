using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FileAccessLog
{
    public int LogId { get; set; }

    public Guid FileId { get; set; }

    public int UserId { get; set; }

    public string Action { get; set; } = null!;

    public DateTime AccessedAt { get; set; }

    public string? IpAddress { get; set; }

    public string? UserAgent { get; set; }

    public virtual FileMetadatum File { get; set; } = null!;

    public virtual User2 User { get; set; } = null!;
}
