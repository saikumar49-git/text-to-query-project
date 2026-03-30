using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingPlanningApplicationStatus
{
    public int RestampingPlanningStatusId { get; set; }

    public int StatusNumber { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<RestampingPlanningDetail> RestampingPlanningDetails { get; set; } = new List<RestampingPlanningDetail>();

    public virtual ICollection<RestampingPlanningPayment> RestampingPlanningPayments { get; set; } = new List<RestampingPlanningPayment>();
}
