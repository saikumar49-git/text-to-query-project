using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialMeterCubeRate
{
    public int SpecialMeterCubeRateId { get; set; }

    public int LocationId { get; set; }

    public int? NumberOfFloors { get; set; }

    public decimal? SpecialCubeRate { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Location Location { get; set; } = null!;
}
