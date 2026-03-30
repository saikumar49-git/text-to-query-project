using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionPermitDecision
{
    public int DemolitionPermitDecisionId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public int? DemolitionPermitDetailId { get; set; }

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

    public virtual DemolitionPermitApplication? DemolitionPermit { get; set; }

    public virtual DemolitionPermitApplicationDetail? DemolitionPermitDetail { get; set; }
}
