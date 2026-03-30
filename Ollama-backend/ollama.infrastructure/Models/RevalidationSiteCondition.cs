using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RevalidationSiteCondition
{
    public int SiteConditionsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SiteConditionsText { get; set; }
}
