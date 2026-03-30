using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationType
{
    public int SpecialApplicationTypeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public int SpecialApplicationKeyId { get; set; }

    public int LandKeyId { get; set; }

    public string? SpecialApplicationTypeName { get; set; }

    public int? PlanningPermitApplicationFormTypeId { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual LandKey LandKey { get; set; } = null!;

    public virtual ICollection<OwnershipChangeAssessmentFeeCalculation> OwnershipChangeAssessmentFeeCalculations { get; set; } = new List<OwnershipChangeAssessmentFeeCalculation>();

    public virtual PlanningPermitApplicationFormType? PlanningPermitApplicationFormType { get; set; }

    public virtual ICollection<PlanningPermitAssessmentFeeCalculation> PlanningPermitAssessmentFeeCalculations { get; set; } = new List<PlanningPermitAssessmentFeeCalculation>();

    public virtual ICollection<RemodelingPermitAssessmentFeeCalculation> RemodelingPermitAssessmentFeeCalculations { get; set; } = new List<RemodelingPermitAssessmentFeeCalculation>();

    public virtual ICollection<SpecialApplicationCategoryBasedRate> SpecialApplicationCategoryBasedRates { get; set; } = new List<SpecialApplicationCategoryBasedRate>();

    public virtual SpecialApplicationKey SpecialApplicationKey { get; set; } = null!;

    public virtual ICollection<SpecialApplicationRateCategoryTypeMapping> SpecialApplicationRateCategoryTypeMappings { get; set; } = new List<SpecialApplicationRateCategoryTypeMapping>();

    public virtual ICollection<UtfpassessmentFeeCalculation> UtfpassessmentFeeCalculations { get; set; } = new List<UtfpassessmentFeeCalculation>();
}
