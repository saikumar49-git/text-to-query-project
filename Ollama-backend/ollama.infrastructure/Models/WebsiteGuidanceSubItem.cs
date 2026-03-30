using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteGuidanceSubItem
{
    public int WebsiteGuidanceSubItemsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int Isactive { get; set; }

    public int? WebsiteGuidanceCategoryId { get; set; }

    public string? WebsiteGuidanceSubItemsTitle { get; set; }

    public string? WebsiteGuidanceSubItemsDescription { get; set; }

    public int RankId { get; set; }
}
