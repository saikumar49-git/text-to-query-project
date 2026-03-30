using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitApplication
{
    public int RenovationPermitApplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public DateTime? PermitNumberCreatedOn { get; set; }

    public string? Status { get; set; }

    public string? RenovationPermitNumber { get; set; }

    public bool IsPermitNumberVerified { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual ICollection<RenovationPermitAssessmentFeeCalculation> RenovationPermitAssessmentFeeCalculations { get; set; } = new List<RenovationPermitAssessmentFeeCalculation>();

    public virtual ICollection<RenovationPermitDecisionDetail> RenovationPermitDecisionDetails { get; set; } = new List<RenovationPermitDecisionDetail>();

    public virtual ICollection<RenovationPermitDetail> RenovationPermitDetails { get; set; } = new List<RenovationPermitDetail>();

    public virtual ICollection<RenovationPermitPayment> RenovationPermitPayments { get; set; } = new List<RenovationPermitPayment>();

    public virtual ICollection<RenovationPermitSupportingDocumentDetail> RenovationPermitSupportingDocumentDetails { get; set; } = new List<RenovationPermitSupportingDocumentDetail>();

    public virtual RequestService RequestService { get; set; } = null!;
}
