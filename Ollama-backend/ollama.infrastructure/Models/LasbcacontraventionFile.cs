using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcacontraventionFile
{
    public int FileId { get; set; }

    public int? ContraventionId { get; set; }

    public int? RequestServiceId { get; set; }

    public string? FileName { get; set; }

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? FileContentType { get; set; }

    public int? OffenceId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public bool? IsActive { get; set; }

    public int? UserId { get; set; }
}
