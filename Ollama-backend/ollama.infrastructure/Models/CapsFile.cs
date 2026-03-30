using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CapsFile
{
    public int CapsFileId { get; set; }

    public int CapsId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FileContentType { get; set; }

    public bool? IsActive { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public string? Comments { get; set; }

    public string? Status { get; set; }

    public virtual CapsApplication Caps { get; set; } = null!;
}
