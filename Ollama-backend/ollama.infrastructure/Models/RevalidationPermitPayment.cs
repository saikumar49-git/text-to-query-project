using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationPermitPayment
{
    public int RevalidationPermitPaymentId { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int? RevalidationPermitId { get; set; }

    public int? RevalidationPermitStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? BillReference { get; set; }

    public virtual RevalidationPermitApplication? RevalidationPermit { get; set; }

    public virtual RevalidationPermitApplicationStatus? RevalidationPermitStatus { get; set; }
}
