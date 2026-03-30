using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ApplicantPermitDoc
{
    public int DocumentId { get; set; }

    public int? ApplicantId { get; set; }

    public string? PlanningPermitNumber { get; set; }

    public DateTime? UploadDate { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? FileDescription { get; set; }

    public int? StatusNumber { get; set; }
}
