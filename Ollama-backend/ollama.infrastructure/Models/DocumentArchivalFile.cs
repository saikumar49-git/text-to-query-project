using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DocumentArchivalFile
{
    public int DocumentArchivalFileId { get; set; }

    public int? DocumentArchivalProcessId { get; set; }

    public string FileName { get; set; } = null!;

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public string? QrcodePath { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual DocumentArchivalProcess? DocumentArchivalProcess { get; set; }
}
