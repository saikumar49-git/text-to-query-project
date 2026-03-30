using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SpecialApplicationTypeV2
{
    public int SpecialApplicationTypeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? SpecialApplicationKeyId { get; set; }

    public int LandCategoryId { get; set; }

    public string? SpecialApplicationTypeName { get; set; }
}
