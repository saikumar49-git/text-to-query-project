using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RenovationPermitApplicationFile
{
    public int RenovationPermitApplicationFileId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? FileContentType { get; set; }

    public int? RenovationPermitApplicationId { get; set; }

    public int? DocumentTypeId { get; set; }

    public string? Status { get; set; }
}
