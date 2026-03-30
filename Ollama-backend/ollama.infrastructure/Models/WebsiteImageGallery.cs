using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteImageGallery
{
    public int WebsiteImageGalleryId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public bool IsArchive { get; set; }

    public string? ImageCategory { get; set; }

    public string? ImageTitle { get; set; }

    public string? ImageUrl { get; set; }
}
