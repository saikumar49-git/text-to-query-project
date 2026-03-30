using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingPlanningDecision
{
    public int RestampingPlanningDecisionId { get; set; }

    public int? RestampingPlanningId { get; set; }

    public int? RestampingPlanningDetailId { get; set; }

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

    public virtual RestampingPlanningApplication? RestampingPlanning { get; set; }

    public virtual RestampingPlanningDetail? RestampingPlanningDetail { get; set; }
}
