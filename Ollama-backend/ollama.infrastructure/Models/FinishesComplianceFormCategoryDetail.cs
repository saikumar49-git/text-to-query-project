using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FinishesComplianceFormCategoryDetail
{
    public int FinishesComplianceFormCategoryDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? AdequacySize { get; set; }

    public string? Materialused { get; set; }

    public string? AdequacyStrengthQuality { get; set; }

    public string? Justification { get; set; }

    public int? FinishesComplianceFormId { get; set; }

    public int? FinishesComplianceFormCategoryId { get; set; }

    public string? Signature { get; set; }
}
