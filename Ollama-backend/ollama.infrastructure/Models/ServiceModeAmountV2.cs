using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ServiceModeAmountV2
{
    public int ServiceModeAmountId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int AgencyId { get; set; }

    public int RequestServiceId { get; set; }

    public int ServiceModeId { get; set; }

    public string? Amount { get; set; }

    public string? AmountDescription { get; set; }
}
