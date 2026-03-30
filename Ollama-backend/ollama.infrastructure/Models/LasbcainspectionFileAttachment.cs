using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcainspectionFileAttachment
{
    public int AttachmentId { get; set; }

    public int? FileId { get; set; }

    public int? RequestServiceId { get; set; }

    public int? ApplicationStageId { get; set; }

    public int? UserId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? FileContentType { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? AuthorizationCommenceId { get; set; }
}
