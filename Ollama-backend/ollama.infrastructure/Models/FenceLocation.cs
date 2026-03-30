using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FenceLocation
{
    public int FenceLocationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? FenceLocationCode { get; set; }

    public string? FenceLocationName { get; set; }

    public virtual ICollection<FencingSiteInspectionReport> FencingSiteInspectionReports { get; set; } = new List<FencingSiteInspectionReport>();
}
