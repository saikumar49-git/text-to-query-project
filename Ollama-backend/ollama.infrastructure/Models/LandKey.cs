using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LandKey
{
    public int LandKeyId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public string? LandKeyName { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual ICollection<LandType> LandTypes { get; set; } = new List<LandType>();

    public virtual ICollection<MeterCubeRate> MeterCubeRates { get; set; } = new List<MeterCubeRate>();

    public virtual ICollection<SpecialApplicationCategoryBasedRate> SpecialApplicationCategoryBasedRates { get; set; } = new List<SpecialApplicationCategoryBasedRate>();

    public virtual ICollection<SpecialApplicationType> SpecialApplicationTypes { get; set; } = new List<SpecialApplicationType>();
}
