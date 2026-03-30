using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationPermitApplicationStatus
{
    public int RevalidationPermitStatusId { get; set; }

    public int StatusNumber { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<RevalidationPermitApplicationDetail> RevalidationPermitApplicationDetails { get; set; } = new List<RevalidationPermitApplicationDetail>();

    public virtual ICollection<RevalidationPermitPayment> RevalidationPermitPayments { get; set; } = new List<RevalidationPermitPayment>();
}
