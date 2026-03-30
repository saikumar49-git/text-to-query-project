using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingPlanningApplication
{
    public int RestampingPlanningId { get; set; }

    public string ApplicationNumber { get; set; } = null!;

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? RestampingPermitNumber { get; set; }

    public DateTime? RestampingPermitNumberCreatedOn { get; set; }

    public bool IsPermitNumberVerified { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual RequestService RequestService { get; set; } = null!;

    public virtual ICollection<RestampingAssessmentFeeCalculation> RestampingAssessmentFeeCalculations { get; set; } = new List<RestampingAssessmentFeeCalculation>();

    public virtual ICollection<RestampingPlanningApplicationFile> RestampingPlanningApplicationFiles { get; set; } = new List<RestampingPlanningApplicationFile>();

    public virtual ICollection<RestampingPlanningDecision> RestampingPlanningDecisions { get; set; } = new List<RestampingPlanningDecision>();

    public virtual ICollection<RestampingPlanningDetail> RestampingPlanningDetails { get; set; } = new List<RestampingPlanningDetail>();

    public virtual ICollection<RestampingPlanningPayment> RestampingPlanningPayments { get; set; } = new List<RestampingPlanningPayment>();
}
