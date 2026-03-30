using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitDetail
{
    public int RenovationPermitDetailId { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? RenovationPermitApplicationStatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual RenovationPermitApplication? RenovationPermitApplication { get; set; }

    public virtual RenovationPermitApplicationStatus? RenovationPermitApplicationStatus { get; set; }

    public virtual ICollection<RenovationPermitDecisionDetail> RenovationPermitDecisionDetails { get; set; } = new List<RenovationPermitDecisionDetail>();

    public virtual ICollection<RenovationPermitSupportingDocumentDetail> RenovationPermitSupportingDocumentDetails { get; set; } = new List<RenovationPermitSupportingDocumentDetail>();
}
