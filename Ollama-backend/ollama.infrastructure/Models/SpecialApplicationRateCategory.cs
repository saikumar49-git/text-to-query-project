using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationRateCategory
{
    public int SpecialApplicationRateCategoryId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SpecialApplicationRateCategoryName { get; set; }

    public int? MinimumPumps { get; set; }

    public int? MaximumPumps { get; set; }

    public int? MultiplyFactor { get; set; }

    public virtual ICollection<PlanningPermitAssessmentFeeCalculation> PlanningPermitAssessmentFeeCalculations { get; set; } = new List<PlanningPermitAssessmentFeeCalculation>();

    public virtual ICollection<RemodelingPermitAssessmentFeeCalculation> RemodelingPermitAssessmentFeeCalculations { get; set; } = new List<RemodelingPermitAssessmentFeeCalculation>();

    public virtual ICollection<SpecialApplicationCategoryBasedRate> SpecialApplicationCategoryBasedRates { get; set; } = new List<SpecialApplicationCategoryBasedRate>();

    public virtual ICollection<SpecialApplicationRateCategoryTypeMapping> SpecialApplicationRateCategoryTypeMappings { get; set; } = new List<SpecialApplicationRateCategoryTypeMapping>();
}
