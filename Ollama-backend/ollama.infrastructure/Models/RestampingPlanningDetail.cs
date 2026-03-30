using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingPlanningDetail
{
    public int RestampingPlanningDetailId { get; set; }

    public int? RestampingPlanningId { get; set; }

    public int? RestampingPlanningStatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual RestampingPlanningApplication? RestampingPlanning { get; set; }

    public virtual ICollection<RestampingPlanningDecision> RestampingPlanningDecisions { get; set; } = new List<RestampingPlanningDecision>();

    public virtual RestampingPlanningApplicationStatus? RestampingPlanningStatus { get; set; }
}
