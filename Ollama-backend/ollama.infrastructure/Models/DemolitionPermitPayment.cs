using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionPermitPayment
{
    public int DemolitionPermitPaymentId { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int? DemolitionPermitId { get; set; }

    public int? DemolitionPermitStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? BillReference { get; set; }

    public virtual DemolitionPermitApplication? DemolitionPermit { get; set; }

    public virtual DemolitionPermitApplicationStatus? DemolitionPermitStatus { get; set; }
}
