using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OtherServiceCharge
{
    public int OtherServiceChargeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int RequestServiceId { get; set; }

    public decimal? ProcessingFeePercent { get; set; }

    public decimal? Rate { get; set; }

    public int? DurationValue { get; set; }

    public string? DurationUnit { get; set; }

    public int? Months { get; set; }

    public virtual RequestService RequestService { get; set; } = null!;
}
