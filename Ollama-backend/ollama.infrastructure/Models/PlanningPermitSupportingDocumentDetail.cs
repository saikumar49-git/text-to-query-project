using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitSupportingDocumentDetail
{
    public int PpsupportingDocumentDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int PlanningPermitApplicationDetailId { get; set; }

    public int PlanningPermitSupportingDocumentId { get; set; }

    public string? PropertyTitleType { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? FileContentType { get; set; }

    public bool? Lirs { get; set; }

    public string? FileDescription { get; set; }

    public virtual PlanningPermitApplicationDetail PlanningPermitApplicationDetail { get; set; } = null!;

    public virtual PlanningPermitSupportingDocument PlanningPermitSupportingDocument { get; set; } = null!;
}
