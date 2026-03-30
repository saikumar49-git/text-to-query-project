using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitDecisionDetail
{
    public int RenovationPermitDecisionId { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? RenovationPermitDetailId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public int? FieldOfficerUid { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? IsDemandNoticeIssued { get; set; }

    public string? SupportingDocumentIds { get; set; }

    public int? DocumentRejectionId { get; set; }

    public virtual RenovationPermitApplication? RenovationPermitApplication { get; set; }

    public virtual RenovationPermitDetail? RenovationPermitDetail { get; set; }
}
