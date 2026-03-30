using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionApplicationBySelfFile
{
    public int DemolitionPermitFileId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public string FileName { get; set; } = null!;

    public string? Type { get; set; }

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual LasbcademolitionApplicationBySelf? DemolitionPermit { get; set; }
}
