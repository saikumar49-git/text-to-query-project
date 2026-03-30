using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitSupportingDocument
{
    public int PlanningPermitSupportingDocumentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SupportingDocument { get; set; }

    public string? SupportingDocumentDescription { get; set; }

    public bool? MandatoryIfMoreThan3Floors { get; set; }

    public bool? MandatoryDocument { get; set; }

    public virtual ICollection<PlanningPermitSupportingDocumentDetail> PlanningPermitSupportingDocumentDetails { get; set; } = new List<PlanningPermitSupportingDocumentDetail>();
}
