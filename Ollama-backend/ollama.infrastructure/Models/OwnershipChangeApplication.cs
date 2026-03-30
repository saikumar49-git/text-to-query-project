using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipChangeApplication
{
    public int OwnershipChangeApplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int AgencyId { get; set; }

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public DateTime? PermitNumberCreatedOn { get; set; }

    public string? Status { get; set; }

    public bool? IsPermitNumberVerified { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public string? PlanningPermitNumber { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual ICollection<OwnershipChangeApplicationDetail> OwnershipChangeApplicationDetails { get; set; } = new List<OwnershipChangeApplicationDetail>();

    public virtual ICollection<OwnershipChangeApplicationFormDetail> OwnershipChangeApplicationFormDetails { get; set; } = new List<OwnershipChangeApplicationFormDetail>();

    public virtual ICollection<OwnershipChangeAssessmentFeeCalculation> OwnershipChangeAssessmentFeeCalculations { get; set; } = new List<OwnershipChangeAssessmentFeeCalculation>();

    public virtual ICollection<OwnershipChangePayment> OwnershipChangePayments { get; set; } = new List<OwnershipChangePayment>();

    public virtual PlanningPermitApplicationV2? PlanningPermitApplication { get; set; }

    public virtual RequestService RequestService { get; set; } = null!;
}
