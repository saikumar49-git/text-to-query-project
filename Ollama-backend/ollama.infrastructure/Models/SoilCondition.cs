using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SoilCondition
{
    public int SoilConditionId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SoilConditionCode { get; set; }

    public string? SoilConditionName { get; set; }

    public virtual ICollection<FencingSiteInspectionReport> FencingSiteInspectionReports { get; set; } = new List<FencingSiteInspectionReport>();
}
