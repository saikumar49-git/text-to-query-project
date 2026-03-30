using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitApplication
{
    public int RemodelingPermitApplicationId { get; set; }

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

    public bool? IsPermitNumberVerified { get; set; }

    public string? Status { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public string? FornaxApplicationNumber { get; set; }

    public bool? IsBlacklisted { get; set; }

    public DateTime? BlacklistedDateTime { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public string? PlanningPermitNumber { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual ICollection<RemodelingElectricalVettingFormDetail> RemodelingElectricalVettingFormDetails { get; set; } = new List<RemodelingElectricalVettingFormDetail>();

    public virtual ICollection<RemodelingPermitApplicationDetail> RemodelingPermitApplicationDetails { get; set; } = new List<RemodelingPermitApplicationDetail>();

    public virtual ICollection<RemodelingPermitArchitecturalVettingFormDetail> RemodelingPermitArchitecturalVettingFormDetails { get; set; } = new List<RemodelingPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<RemodelingPermitAssessmentFeeCalculation> RemodelingPermitAssessmentFeeCalculations { get; set; } = new List<RemodelingPermitAssessmentFeeCalculation>();

    public virtual ICollection<RemodelingPermitCalculation> RemodelingPermitCalculations { get; set; } = new List<RemodelingPermitCalculation>();

    public virtual ICollection<RemodelingPermitFornaxProjectDetail> RemodelingPermitFornaxProjectDetails { get; set; } = new List<RemodelingPermitFornaxProjectDetail>();

    public virtual ICollection<RemodelingPermitPayment> RemodelingPermitPayments { get; set; } = new List<RemodelingPermitPayment>();

    public virtual ICollection<RemodelingStructuralVettingFormDetail> RemodelingStructuralVettingFormDetails { get; set; } = new List<RemodelingStructuralVettingFormDetail>();

    public virtual RequestService RequestService { get; set; } = null!;
}
