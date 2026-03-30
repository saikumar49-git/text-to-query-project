using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteGuidanceCategory
{
    public int WebsiteGuidanceCategoryId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int Isactive { get; set; }

    public string? GuidanceCategoryTitle { get; set; }

    public string? GudanceCategoryDescription { get; set; }

    public int RankId { get; set; }
}
