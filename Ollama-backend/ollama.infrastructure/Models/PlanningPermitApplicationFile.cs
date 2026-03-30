using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationFile
{
    public int PlanningPermitApplicationFileId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? PlanningPermitApplicationDetailId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? FileContentType { get; set; }

    public int? UploadedFileCategoryId { get; set; }

    public bool? IsArchitectural { get; set; }

    public bool? IsSurveyMap { get; set; }

    public virtual PlanningPermitApplicationDetail? PlanningPermitApplicationDetail { get; set; }

    public virtual UploadedFileCategory? UploadedFileCategory { get; set; }
}
