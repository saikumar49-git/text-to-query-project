using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyApplicationFile
{
    public int CtcapplicationFileId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CtcapplicationId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? UploadedBy { get; set; }

    public virtual CertifiedTrueCopyApplication? Ctcapplication { get; set; }
}
