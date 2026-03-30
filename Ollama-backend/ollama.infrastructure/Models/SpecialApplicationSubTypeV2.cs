using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationSubTypeV2
{
    public int SpecialApplicationSubTypeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SpecialApplicationSubTypeName { get; set; }

    public int? SpecialApplicationSubId { get; set; }
}
