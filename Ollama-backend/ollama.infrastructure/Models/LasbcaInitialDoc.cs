using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaInitialDoc
{
    public int DocumentId { get; set; }

    public int RequestServiceId { get; set; }

    public string? DocumentName { get; set; }

    public bool IsRequired { get; set; }

    public int? NumberofFloors { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? Modifiedby { get; set; }

    public bool? IsActive { get; set; }
}
