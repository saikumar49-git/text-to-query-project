using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebSiteGetInvolvedSite
{
    public int WebSiteGetInvolvedSitesId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? Title { get; set; }

    public string? ImageUrl { get; set; }

    public string? RedirectUrl { get; set; }
}
