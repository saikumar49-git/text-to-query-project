using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyPayment
{
    public int CtcpaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string PaymentReferenceNumber { get; set; } = null!;

    public int CtcapplicationId { get; set; }

    public int CtcapplicationStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? PaymentId { get; set; }

    public string? Status { get; set; }

    public string? BillReference { get; set; }

    public virtual CertifiedTrueCopyApplication Ctcapplication { get; set; } = null!;

    public virtual CertifiedTrueCopyApplicationStatus CtcapplicationStatus { get; set; } = null!;
}
