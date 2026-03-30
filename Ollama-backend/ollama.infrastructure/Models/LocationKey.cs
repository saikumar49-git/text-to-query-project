using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LocationKey
{
    public int LocationKeyId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public string? LocationKeyName { get; set; }

    public decimal? RegistrationFee { get; set; }

    public decimal? LayoutFee { get; set; }

    public decimal? PerFloorRatio { get; set; }

    public decimal? SpecialApplicationLayoutFee { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual ICollection<Location> Locations { get; set; } = new List<Location>();

    public virtual ICollection<MeterCubeRate> MeterCubeRates { get; set; } = new List<MeterCubeRate>();

    public virtual ICollection<SpecialApplicationCategoryBasedRate> SpecialApplicationCategoryBasedRates { get; set; } = new List<SpecialApplicationCategoryBasedRate>();
}
