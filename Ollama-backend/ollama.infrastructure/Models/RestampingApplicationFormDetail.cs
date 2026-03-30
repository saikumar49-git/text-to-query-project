using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingApplicationFormDetail
{
    public int RestampingApplicationFormDetailId { get; set; }

    public int? PermitId { get; set; }

    public string? ApplicantInformation { get; set; }

    public string? PropertyInformation { get; set; }

    public string? OriginalPermitInformation { get; set; }

    public string? DeclarationInformation { get; set; }

    public string? PaymentInformation { get; set; }

    public int? RestampingReason { get; set; }

    public string? RestampingreasonOtherText { get; set; }

    public string? ProjectDescription { get; set; }

    public string? ProjectChanges { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ServiceModeId { get; set; }
}
