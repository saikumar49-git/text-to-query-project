using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitPayment
{
    public int RemodelingPermitPaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int RemodelingPermitApplicationId { get; set; }

    public int RemodelingPermitApplicationStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? BillReference { get; set; }

    public virtual RemodelingPermitApplication RemodelingPermitApplication { get; set; } = null!;

    public virtual ICollection<RemodelingPermitPaymentReceipt> RemodelingPermitPaymentReceipts { get; set; } = new List<RemodelingPermitPaymentReceipt>();
}
