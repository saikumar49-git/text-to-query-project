using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitLirsdetailsV2
{
    public int PlanningPermitLirsdetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int PlanningPermitApplicationId { get; set; }

    public string? ApplicationNumber { get; set; }

    public string? PayerId { get; set; }

    public string? ApplicantName { get; set; }

    public string? ReceiptNumber { get; set; }

    public DateTime? DateOfPayment { get; set; }

    public string? Amount { get; set; }

    public string? Bank { get; set; }

    public string? Year { get; set; }

    public virtual PlanningPermitApplicationV2 PlanningPermitApplication { get; set; } = null!;
}
