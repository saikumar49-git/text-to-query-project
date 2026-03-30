using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AnouncementsAndPressRelease
{
    public int AnouncementsAndPressReleasesId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public int? MinistryId { get; set; }

    public string? AnouncementTitle { get; set; }

    public string? AnouncementDescription { get; set; }

    public DateOnly? AnouncementDate { get; set; }
}
