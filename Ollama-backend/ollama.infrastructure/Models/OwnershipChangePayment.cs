using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipChangePayment
{
    public int OwnershipChangePaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int OwnershipChangeApplicationId { get; set; }

    public int OwnershipChangeApplicationStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? BillReference { get; set; }

    public virtual OwnershipChangeApplication OwnershipChangeApplication { get; set; } = null!;

    public virtual OwnershipChangeApplicationStatus OwnershipChangeApplicationStatus { get; set; } = null!;

    public virtual ICollection<OwnershipChangePaymentReceipt> OwnershipChangePaymentReceipts { get; set; } = new List<OwnershipChangePaymentReceipt>();
}
