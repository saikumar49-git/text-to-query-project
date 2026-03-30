using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitPaymentReceipt
{
    public int FencingPermitPaymentReceiptId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string FencingPermitPaymentId { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string? FileContent { get; set; }
}
