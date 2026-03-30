using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Ministry
{
    public int MinistryId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? AboutMinistry { get; set; }

    public string? MinisterName { get; set; }

    public string? MinisterImageUrl { get; set; }

    public string? MinisterDescription { get; set; }

    public string? MinisterStatement { get; set; }

    public string? DepartmentsAndDivisions { get; set; }

    public string? AnouncementsAndPressReleases { get; set; }
}
