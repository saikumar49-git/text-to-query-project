using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebSiteEpppsstep
{
    public int WebSiteEpppsstepsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int WebSiteWelcomeContentId { get; set; }

    public string? WebSiteEpppsstepsTitle { get; set; }

    public string? WebSiteEpppsstepsDescription { get; set; }

    public string? WebSiteEpppsstepsImageUrl { get; set; }
}
