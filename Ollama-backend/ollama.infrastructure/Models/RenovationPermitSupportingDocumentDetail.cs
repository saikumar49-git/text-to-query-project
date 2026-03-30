using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitSupportingDocumentDetail
{
    public int RpsupportingDocumentDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? RenovationPermitDetailId { get; set; }

    public int? RenovationPermitSupportingDocumentId { get; set; }

    public string? PropertyTitleType { get; set; }

    public string? FilePath { get; set; }

    public string? FileName { get; set; }

    public string? FileContentType { get; set; }

    public string? FileDescription { get; set; }

    public virtual RenovationPermitApplication? RenovationPermitApplication { get; set; }

    public virtual RenovationPermitDetail? RenovationPermitDetail { get; set; }

    public virtual RenovationPermitSupportingDocument? RenovationPermitSupportingDocument { get; set; }
}
