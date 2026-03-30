using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitVettingFormDetailsV2
{
    public int RemodelingPermitVettingFormId { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public int? EngineerTypeId { get; set; }

    public string? FormDetails { get; set; }

    public bool? IsSatisfy { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? EngineerDecision { get; set; }
}
