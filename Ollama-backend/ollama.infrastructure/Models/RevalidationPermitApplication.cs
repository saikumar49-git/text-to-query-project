using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationPermitApplication
{
    public int RevalidationPermitId { get; set; }

    public string ApplicationNumber { get; set; } = null!;

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? RevalidationPermitNumber { get; set; }

    public DateTime? RevalidationPermitNumberCreatedOn { get; set; }

    public bool IsPermitNumberVerified { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public bool IsSiteInspectionRequired { get; set; }

    public long? FieldOfficerUid { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual RequestService RequestService { get; set; } = null!;

    public virtual ICollection<RevalidationAssessmentFeeCalculation> RevalidationAssessmentFeeCalculations { get; set; } = new List<RevalidationAssessmentFeeCalculation>();

    public virtual ICollection<RevalidationPermitApplicationDetail> RevalidationPermitApplicationDetails { get; set; } = new List<RevalidationPermitApplicationDetail>();

    public virtual ICollection<RevalidationPermitApplicationFile> RevalidationPermitApplicationFiles { get; set; } = new List<RevalidationPermitApplicationFile>();

    public virtual ICollection<RevalidationPermitDecision> RevalidationPermitDecisions { get; set; } = new List<RevalidationPermitDecision>();

    public virtual ICollection<RevalidationPermitPayment> RevalidationPermitPayments { get; set; } = new List<RevalidationPermitPayment>();
}
