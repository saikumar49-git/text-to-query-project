using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitSiteInspectionReportV2
{
    public int PpsiteInspectionReportId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public string? FormDetails { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
