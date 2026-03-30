using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AmountPayableParametersV2
{
    public int AmountPayableParametersId { get; set; }

    public string? ParameterName { get; set; }

    public string? ParameterDescription { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? AmountPayableReference { get; set; }
}
