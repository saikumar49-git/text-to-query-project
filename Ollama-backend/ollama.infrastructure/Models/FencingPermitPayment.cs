using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitPayment
{
    public int FencingPermitPaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int FencingPermitApplicationId { get; set; }

    public int FencingPermitApplicationStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? BillReference { get; set; }

    public virtual FencingPermitApplication FencingPermitApplication { get; set; } = null!;
}
