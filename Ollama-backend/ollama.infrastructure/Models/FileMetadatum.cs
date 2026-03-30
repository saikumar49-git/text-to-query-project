using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FileMetadatum
{
    public Guid FileId { get; set; }

    public int UserId { get; set; }

    public string FileName { get; set; } = null!;

    public string OriginalFileName { get; set; } = null!;

    public string ContentType { get; set; } = null!;

    public long FileSizeInBytes { get; set; }

    public string BlobName { get; set; } = null!;

    public string ContainerName { get; set; } = null!;

    public int Status { get; set; }

    public DateTime CreatedAt { get; set; }

    public DateTime? UploadedAt { get; set; }

    public DateTime? DeletedAt { get; set; }

    public string? Tags { get; set; }

    public string? Description { get; set; }

    public int? TotalChunks { get; set; }

    public int? UploadedChunks { get; set; }

    public string? ChunkBlockIds { get; set; }

    public virtual ICollection<FileAccessLog> FileAccessLogs { get; set; } = new List<FileAccessLog>();

    public virtual ICollection<FileShare> FileShares { get; set; } = new List<FileShare>();

    public virtual User2 User { get; set; } = null!;
}
