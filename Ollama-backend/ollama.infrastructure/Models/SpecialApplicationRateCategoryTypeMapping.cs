using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationRateCategoryTypeMapping
{
    public int SpecialApplicationRateCategoryTypeMappingId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int SpecialApplicationRateCategoryId { get; set; }

    public int SpecialApplicationTypeId { get; set; }

    public virtual SpecialApplicationRateCategory SpecialApplicationRateCategory { get; set; } = null!;

    public virtual SpecialApplicationType SpecialApplicationType { get; set; } = null!;
}
