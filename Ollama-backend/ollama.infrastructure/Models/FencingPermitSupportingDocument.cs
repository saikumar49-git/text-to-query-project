using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitSupportingDocument
{
    public int FencingPermitSupportingDocumentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SupportingDocument { get; set; }

    public string? SupportingDocumentDescription { get; set; }

    public bool? MandatoryDocument { get; set; }

    public bool? IsSupportingDocument { get; set; }

    public virtual ICollection<FencingPermitSupportingDocumentDetail> FencingPermitSupportingDocumentDetails { get; set; } = new List<FencingPermitSupportingDocumentDetail>();
}
