using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitPaymentReceipt
{
    public int RemodelingPermitPaymentReceiptId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RemodelingPermitPaymentId { get; set; }

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? FileContent { get; set; }

    public bool? ReceiptType { get; set; }

    public virtual RemodelingPermitPayment? RemodelingPermitPayment { get; set; }
}
