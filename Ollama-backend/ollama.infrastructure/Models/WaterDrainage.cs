using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WaterDrainage
{
    public int WaterDrainageId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? WaterDrainageCode { get; set; }

    public string? WaterDrainageName { get; set; }

    public virtual ICollection<FencingSiteInspectionReport> FencingSiteInspectionReports { get; set; } = new List<FencingSiteInspectionReport>();
}
