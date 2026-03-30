using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RmdmapDetail
{
    public int RmdmapDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? Rmdid { get; set; }

    public int? DistrictId { get; set; }

    public int? CityId { get; set; }

    public int? Lgaid { get; set; }

    public int? StateId { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Rmdtitle { get; set; }

    public string? Description { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? UploadedBy { get; set; }
}
