using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AmountPayableParameter
{
    public int ParameterId { get; set; }

    public string? ParameterName { get; set; }

    public double? AssessmentFeePercent { get; set; }

    public int? Rate { get; set; }

    public int? ParameterValue { get; set; }
}
