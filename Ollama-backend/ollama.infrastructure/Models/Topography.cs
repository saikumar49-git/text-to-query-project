using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Topography
{
    public int TopographyId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? TopographyCode { get; set; }

    public string? TopographyName { get; set; }

    public virtual ICollection<FencingSiteInspectionReport> FencingSiteInspectionReports { get; set; } = new List<FencingSiteInspectionReport>();
}
