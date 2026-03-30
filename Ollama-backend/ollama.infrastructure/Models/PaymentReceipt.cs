using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PaymentReceipt
{
    public int PaymentReceiptId { get; set; }

    public int? PermitId { get; set; }

    public int? PaymentId { get; set; }

    public int? RequestServiceId { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? FileContentType { get; set; }

    public string? FileDescription { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int? StatusId { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public string? Amount { get; set; }

    public string? StatusMessage { get; set; }

    public string? RevenueReceiptUrl { get; set; }

    public decimal? PaymentAmount { get; set; }

    public string? BillReference { get; set; }

    public string? TransactionReference { get; set; }

    public bool? PaymentStatus { get; set; }

    public string? Status { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public int? TransactionById { get; set; }

    public int? PaymentTypeId { get; set; }
}
