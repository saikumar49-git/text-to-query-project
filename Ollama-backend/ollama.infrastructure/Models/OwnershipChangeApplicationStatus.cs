using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipChangeApplicationStatus
{
    public int OwnershipChangeApplicationStatusId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RequestServiceId { get; set; }

    public string? StatusName { get; set; }

    public string? StatusMessage { get; set; }

    public virtual ICollection<OwnershipChangeApplicationDetail> OwnershipChangeApplicationDetails { get; set; } = new List<OwnershipChangeApplicationDetail>();

    public virtual ICollection<OwnershipChangePayment> OwnershipChangePayments { get; set; } = new List<OwnershipChangePayment>();

    public virtual RequestService? RequestService { get; set; }
}
