using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebSiteActivitiesAndInitiative
{
    public int WebSiteActivitiesAndInitiativesId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string WebSiteActivitiesAndInitiativesTitle { get; set; } = null!;

    public string WebSiteActivitiesAndInitiativesDescription { get; set; } = null!;

    public string? WebSiteActivitiesAndInitiativesFollowUsUrl { get; set; }
}
