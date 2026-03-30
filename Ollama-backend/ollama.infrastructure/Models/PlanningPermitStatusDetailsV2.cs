using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitStatusDetailsV2
{
    public int PlanningPermitStatusDetailId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitApplicationStatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
