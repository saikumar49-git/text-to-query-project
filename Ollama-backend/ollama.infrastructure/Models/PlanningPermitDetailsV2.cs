using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitDetailsV2
{
    public int PlanningPermitDetailId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitStatusDetailId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public int? FieldOfficerUid { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public int? PlanningPermitTypeId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? DocumentRejectionId { get; set; }

    public bool? IsBlacklisted { get; set; }

    public DateTime? BlacklistedDateTime { get; set; }

    public string? SupportingDocumentIds { get; set; }

    public bool? IsDemandNoticeIssued { get; set; }

    public string? OtherDocumentDescription { get; set; }
}
