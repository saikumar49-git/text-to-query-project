using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitApplicationStatus
{
    public int RenovationPermitApplicationStatusId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RequestServiceId { get; set; }

    public string? StatusName { get; set; }

    public string? StatusMessage { get; set; }

    public string? StatusNumber { get; set; }

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual ICollection<RenovationPermitDetail> RenovationPermitDetails { get; set; } = new List<RenovationPermitDetail>();

    public virtual ICollection<RenovationPermitPayment> RenovationPermitPayments { get; set; } = new List<RenovationPermitPayment>();

    public virtual RequestService? RequestService { get; set; }
}
