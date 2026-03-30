using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationSubTypeInfoV2
{
    public int SpecialApplicationSubTypeInfoId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? SpecialApplicationSubId { get; set; }

    public int? MinimumPumps { get; set; }

    public int? MaximumPumps { get; set; }

    public decimal? MultiplyFactor { get; set; }
}
