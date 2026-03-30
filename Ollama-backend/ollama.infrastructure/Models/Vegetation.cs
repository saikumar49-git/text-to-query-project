using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Vegetation
{
    public int VegetationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? VegetationCode { get; set; }

    public string? VegetationName { get; set; }

    public virtual ICollection<FencingSiteInspectionReport> FencingSiteInspectionReports { get; set; } = new List<FencingSiteInspectionReport>();
}
