using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FileShare
{
    public int ShareId { get; set; }

    public Guid FileId { get; set; }

    public int SharedByUserId { get; set; }

    public int SharedWithUserId { get; set; }

    public DateTime SharedAt { get; set; }

    public DateTime? ExpiresAt { get; set; }

    public bool CanEdit { get; set; }

    public bool CanDelete { get; set; }

    public virtual FileMetadatum File { get; set; } = null!;

    public virtual User2 SharedByUser { get; set; } = null!;

    public virtual User2 SharedWithUser { get; set; } = null!;
}
