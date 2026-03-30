using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RestampingPlanningPayment
{
    public int RestampingPlanningPaymentId { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int? RestampingPlanningId { get; set; }

    public int? RestampingPlanningStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? BillReference { get; set; }

    public virtual RestampingPlanningApplication? RestampingPlanning { get; set; }

    public virtual RestampingPlanningApplicationStatus? RestampingPlanningStatus { get; set; }
}
