using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationPermitApplicationDetail
{
    public int RevalidationPermitDetailId { get; set; }

    public int? RevalidationPermitId { get; set; }

    public int? RevalidationPermitStatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual RevalidationPermitApplication? RevalidationPermit { get; set; }

    public virtual ICollection<RevalidationPermitDecision> RevalidationPermitDecisions { get; set; } = new List<RevalidationPermitDecision>();

    public virtual RevalidationPermitApplicationStatus? RevalidationPermitStatus { get; set; }
}
