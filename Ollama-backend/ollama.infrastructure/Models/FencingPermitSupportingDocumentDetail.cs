using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitSupportingDocumentDetail
{
    public int FpsupportingDocumentDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? FencingPermitApplicationDetailId { get; set; }

    public int FencingPermitSupportingDocumentId { get; set; }

    public string? PropertyTitleType { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? FileContentType { get; set; }

    public bool? Lirs { get; set; }

    public string? OtherDocumentTypeText { get; set; }

    public string? FileDescription { get; set; }

    public string? Status { get; set; }

    public int? FencingPermitApplicationId { get; set; }

    public int? StampingStatus { get; set; }

    public virtual FencingPermitSupportingDocument FencingPermitSupportingDocument { get; set; } = null!;
}
