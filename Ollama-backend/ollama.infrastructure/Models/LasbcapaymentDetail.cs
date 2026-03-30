using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcapaymentDetail
{
    public int PaymentId { get; set; }

    public string PaymentReferenceNumber { get; set; } = null!;

    public string? Process { get; set; }

    public int? ApplicationId { get; set; }

    public int? StatusId { get; set; }

    public string? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
