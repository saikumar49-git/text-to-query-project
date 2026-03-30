using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitVettingFormDetail
{
    public int RenovationPermitVettingFormId { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? EngineerTypeId { get; set; }

    public string? FormDetails { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }
}
