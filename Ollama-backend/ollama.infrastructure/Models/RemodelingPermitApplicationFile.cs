using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitApplicationFile
{
    public int RemodelingPermitApplicationFileId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RemodelingPermitApplicationDetailId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? FileContentType { get; set; }

    public int? UploadedFileCategoryId { get; set; }

    public bool? IsArchitectural { get; set; }

    public bool? IsSurveyMap { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public int? DocumentTypeId { get; set; }

    public int? StampingStatus { get; set; }
}
