using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebSiteWelcomeContent
{
    public int WebSiteWelcomeContentId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? WelcomeTitle { get; set; }

    public string? WelcomeDescription { get; set; }

    public string? WelcomeVideoUrl { get; set; }

    public string? HowEpppsworks { get; set; }

    public string? WelcomeVideoThumbnailImageUrl { get; set; }

    public string? EpppsfollowUsUrl { get; set; }

    public string? WebSiteBackgorundImageUrl { get; set; }

    public string? EpppstwitterUrl { get; set; }

    public string? EpppsinstagramUrl { get; set; }

    public string? EpppsfacebookUrl { get; set; }

    public string? EpppslinkedInUrl { get; set; }
}
