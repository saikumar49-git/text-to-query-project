using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MeterCubeRate
{
    public int MeterCubeRateId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public int LocationKeyId { get; set; }

    public int LandKeyId { get; set; }

    public decimal? MeterCubeRate1 { get; set; }

    public int? NumberOfFloors { get; set; }

    public decimal? SpecialCubeRate { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual LandKey LandKey { get; set; } = null!;

    public virtual LocationKey LocationKey { get; set; } = null!;
}
