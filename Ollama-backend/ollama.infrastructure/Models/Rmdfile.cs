using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Rmdfile
{
    public int RmdfileId { get; set; }

    public int? Rmdid { get; set; }

    public string? FileName { get; set; }

    public string? ContentType { get; set; }

    public string? FileDescription { get; set; }

    public string? FilePath { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Rmdapplication? Rmd { get; set; }
}
