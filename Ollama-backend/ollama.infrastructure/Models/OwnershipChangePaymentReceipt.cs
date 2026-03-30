using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipChangePaymentReceipt
{
    public int OwnershipChangePaymentReceiptId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int OwnershipChangePaymentId { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? FileContent { get; set; }

    public virtual OwnershipChangePayment OwnershipChangePayment { get; set; } = null!;
}
