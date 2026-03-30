using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationPermitDecision
{
    public int RevalidationPermitDecisionId { get; set; }

    public int? RevalidationPermitId { get; set; }

    public int? RevalidationPermitDetailId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? FieldOfficerUid { get; set; }

    public string? ApplicantScheduledDates { get; set; }

    public string? DoapprovedScheduledDate { get; set; }

    public virtual RevalidationPermitApplication? RevalidationPermit { get; set; }

    public virtual RevalidationPermitApplicationDetail? RevalidationPermitDetail { get; set; }
}
