using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AgencyFunction
{
    public int AgencyFunctionsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int? AgencyId { get; set; }

    public string FunctionName { get; set; } = null!;

    public string? FunctionDescription { get; set; }

    public string? FunctionCode { get; set; }
}
