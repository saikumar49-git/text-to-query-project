using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitPayment
{
    public int RenovationPermitPaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int RenovationPermitApplicationId { get; set; }

    public int RenovationPermitApplicationStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public string? Status { get; set; }

    public string? BillReference { get; set; }

    public virtual RenovationPermitApplication RenovationPermitApplication { get; set; } = null!;

    public virtual RenovationPermitApplicationStatus RenovationPermitApplicationStatus { get; set; } = null!;
}
