using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitApplication
{
    public int FencingPermitApplicationId { get; set; }

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

    public string? PropertyLocationDetail { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual ICollection<FencingPermitApplicationDetail> FencingPermitApplicationDetails { get; set; } = new List<FencingPermitApplicationDetail>();

    public virtual ICollection<FencingPermitCalculation> FencingPermitCalculations { get; set; } = new List<FencingPermitCalculation>();

    public virtual ICollection<FencingPermitDocumentChecklistDetail> FencingPermitDocumentChecklistDetails { get; set; } = new List<FencingPermitDocumentChecklistDetail>();

    public virtual ICollection<FencingPermitPayment> FencingPermitPayments { get; set; } = new List<FencingPermitPayment>();

    public virtual ICollection<FencingStructuralVettingFormDetail> FencingStructuralVettingFormDetails { get; set; } = new List<FencingStructuralVettingFormDetail>();

    public virtual RequestService RequestService { get; set; } = null!;
}
