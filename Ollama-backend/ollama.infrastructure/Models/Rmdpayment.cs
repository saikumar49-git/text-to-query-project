using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Rmdpayment
{
    public int RmdpaymentId { get; set; }

    public string PaymentReferenceNumber { get; set; } = null!;

    public int? Rmdid { get; set; }

    public int? RmdstatusId { get; set; }

    public string? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Rmdapplication? Rmd { get; set; }

    public virtual Rmdstatus? Rmdstatus { get; set; }
}
