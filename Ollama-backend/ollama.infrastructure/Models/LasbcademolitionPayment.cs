using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcademolitionPayment
{
    public int DemolitionPermitPaymentId { get; set; }

    public string PaymentReferenceNumber { get; set; } = null!;

    public int? DemolitionPermitId { get; set; }

    public int? DemolitionPermitStatusId { get; set; }

    public string? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual LasbcademolitionApplicationBySelf? DemolitionPermit { get; set; }

    public virtual LasbcaselfDemolitionPermitApplicationStatus? DemolitionPermitStatus { get; set; }
}
