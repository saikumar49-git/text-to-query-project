using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitApplicationStatus
{
    public int PlanningPermitApplicationStatusId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RequestServiceId { get; set; }

    public string? StatusName { get; set; }

    public string? StatusMessage { get; set; }

    public string? StatusNumber { get; set; }

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<PlanningPermitPayment> PlanningPermitPayments { get; set; } = new List<PlanningPermitPayment>();

    public virtual RequestService? RequestService { get; set; }
}
