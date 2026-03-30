using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationCategoryBasedRate
{
    public int SpecialApplicationCategoryBasedRateId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? SpecialApplicationRateCategoryId { get; set; }

    public int? SpecialApplicationTypeId { get; set; }

    public int? LocationKeyId { get; set; }

    public decimal? Rate { get; set; }

    public int? SpecialApplicationKeyId { get; set; }

    public int? LandTypeId { get; set; }

    public virtual LandKey? LandType { get; set; }

    public virtual LocationKey? LocationKey { get; set; }

    public virtual SpecialApplicationKey? SpecialApplicationKey { get; set; }

    public virtual SpecialApplicationRateCategory? SpecialApplicationRateCategory { get; set; }

    public virtual SpecialApplicationType? SpecialApplicationType { get; set; }
}
