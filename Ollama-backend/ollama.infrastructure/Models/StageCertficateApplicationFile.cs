using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertficateApplicationFile
{
    public int StageCertificateApplicationFilesId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StageCertificateApplicationId { get; set; }

    public string? FileName { get; set; }

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }
}
