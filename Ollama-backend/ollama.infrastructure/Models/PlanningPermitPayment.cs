using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitPayment
{
    public int PlanningPermitPaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string PaymentReferenceNumber { get; set; } = null!;

    public int PlanningPermitApplicationId { get; set; }

    public int PlanningPermitApplicationStatusId { get; set; }

    public string? Amount { get; set; }

    public virtual PlanningPermitApplication PlanningPermitApplication { get; set; } = null!;

    public virtual PlanningPermitApplicationStatus PlanningPermitApplicationStatus { get; set; } = null!;

    public virtual ICollection<PlanningPermitPaymentReceipt> PlanningPermitPaymentReceipts { get; set; } = new List<PlanningPermitPaymentReceipt>();
}
