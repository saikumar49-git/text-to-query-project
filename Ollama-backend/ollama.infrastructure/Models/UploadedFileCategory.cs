using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UploadedFileCategory
{
    public int UploadedFileCategoryId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string UploadedFileCategoryType { get; set; } = null!;

    public virtual ICollection<FencingPermitApplicationFile> FencingPermitApplicationFiles { get; set; } = new List<FencingPermitApplicationFile>();

    public virtual ICollection<PlanningPermitApplicationFile> PlanningPermitApplicationFiles { get; set; } = new List<PlanningPermitApplicationFile>();
}
