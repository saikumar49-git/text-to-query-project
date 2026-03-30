using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Location
{
    public int LocationId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public int LocationKeyId { get; set; }

    public string? LocationName { get; set; }

    public bool? PremiumArea { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual LocationKey LocationKey { get; set; } = null!;

    public virtual ICollection<OwnershipChangeAssessmentFeeCalculation> OwnershipChangeAssessmentFeeCalculations { get; set; } = new List<OwnershipChangeAssessmentFeeCalculation>();

    public virtual ICollection<PlanningPermitAssessmentFeeCalculation> PlanningPermitAssessmentFeeCalculations { get; set; } = new List<PlanningPermitAssessmentFeeCalculation>();

    public virtual ICollection<RemodelingPermitAssessmentFeeCalculation> RemodelingPermitAssessmentFeeCalculations { get; set; } = new List<RemodelingPermitAssessmentFeeCalculation>();

    public virtual ICollection<RemodelingPermitCalculation> RemodelingPermitCalculations { get; set; } = new List<RemodelingPermitCalculation>();

    public virtual ICollection<RenovationPermitAssessmentFeeCalculation> RenovationPermitAssessmentFeeCalculations { get; set; } = new List<RenovationPermitAssessmentFeeCalculation>();

    public virtual ICollection<RestampingAssessmentFeeCalculation> RestampingAssessmentFeeCalculations { get; set; } = new List<RestampingAssessmentFeeCalculation>();

    public virtual ICollection<RevalidationAssessmentFeeCalculation> RevalidationAssessmentFeeCalculations { get; set; } = new List<RevalidationAssessmentFeeCalculation>();

    public virtual ICollection<SpecialMeterCubeRate> SpecialMeterCubeRates { get; set; } = new List<SpecialMeterCubeRate>();

    public virtual ICollection<UtfpassessmentFeeCalculation> UtfpassessmentFeeCalculations { get; set; } = new List<UtfpassessmentFeeCalculation>();
}
