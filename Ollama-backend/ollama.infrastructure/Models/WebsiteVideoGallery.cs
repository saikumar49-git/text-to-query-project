using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteVideoGallery
{
    public int WebsiteVideoGalleryId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public bool IsArchive { get; set; }

    public string? VideoCategory { get; set; }

    public string? VideoTitle { get; set; }

    public string? VideoUrl { get; set; }

    public string? VideoThumbnailImageUrl { get; set; }
}
