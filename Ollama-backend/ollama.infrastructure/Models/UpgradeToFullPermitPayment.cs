using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UpgradeToFullPermitPayment
{
    public int UpgradeToFullPermitPaymentId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? PaymentReferenceNumber { get; set; }

    public int UpgradeToFullPermitApplicationId { get; set; }

    public int UpgradeToFullPermitApplicationStatusId { get; set; }

    public decimal? Amount { get; set; }

    public string? Status { get; set; }

    public string? BillReference { get; set; }

    public virtual UpgradeToFullPermitApplication UpgradeToFullPermitApplication { get; set; } = null!;
}
