using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcapaymentInvoice
{
    public int InvoiceId { get; set; }

    public int? ApplicationId { get; set; }

    public string? PermitNumber { get; set; }

    public int? RequestServiceId { get; set; }

    public int? TypeOfInvoice { get; set; }

    public decimal? PaymentAmount { get; set; }

    public decimal? Discount { get; set; }

    public decimal? FinalAmount { get; set; }

    public string? Status { get; set; }

    public int? StatusId { get; set; }

    public string? TransactionId { get; set; }

    public string? TransactionReference { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? UserId { get; set; }

    public string? UserInfo { get; set; }

    public int? ApplicationStageId { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? ContraventionId { get; set; }

    public string? BillReference { get; set; }

    public bool PaymentStatus { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? RecieptUrl { get; set; }

    public string? AdditionalInfo { get; set; }
}
