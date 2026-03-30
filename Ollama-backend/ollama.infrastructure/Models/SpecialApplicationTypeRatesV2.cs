using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationTypeRatesV2
{
    public int SpecialApplicationTypeRatesId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? SpecialApplicationKeyId { get; set; }

    public int? SpecialApplicationSubId { get; set; }

    public int? CategoryId { get; set; }

    public decimal? Rate { get; set; }

    public string? CategoryIds { get; set; }
}
