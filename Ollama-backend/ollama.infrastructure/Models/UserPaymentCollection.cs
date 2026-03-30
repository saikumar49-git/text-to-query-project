using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserPaymentCollection
{
    public int UserPaymentCollectionId { get; set; }

    public string? BillReference { get; set; }

    public decimal? AmountPaid { get; set; }

    public string? PaymentReference { get; set; }

    public bool PaymentStatus { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? ReceiptUrl { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ApplicationId { get; set; }

    public int? PaymentBy { get; set; }

    public int? ApplicationStatusId { get; set; }

    public int? PaymentTypeId { get; set; }

    public int? RequestServiceId { get; set; }
}
