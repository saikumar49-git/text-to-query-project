using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ContravenerFile
{
    public int ContravenerFilesId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? FileName { get; set; }

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public int? ContravenerId { get; set; }
}
