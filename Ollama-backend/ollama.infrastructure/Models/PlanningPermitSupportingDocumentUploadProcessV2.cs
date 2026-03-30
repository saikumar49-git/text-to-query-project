using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitSupportingDocumentUploadProcessV2
{
    public int PpsupportingDocumentProcessId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitStatusDetailId { get; set; }

    public int? PlanningPermitStatusId { get; set; }

    public string? SupportingDocumentIds { get; set; }

    public int? Step { get; set; }

    public string? StepStatus { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
