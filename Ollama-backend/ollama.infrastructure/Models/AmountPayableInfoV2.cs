using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AmountPayableInfoV2
{
    public int AmountPayableInfoId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public decimal? AssessmentFeePercent { get; set; }

    public decimal? Rate { get; set; }

    public decimal? ParameterValue { get; set; }

    public int? AmountPayableReference { get; set; }

    public int? FeeTypeId { get; set; }
}
