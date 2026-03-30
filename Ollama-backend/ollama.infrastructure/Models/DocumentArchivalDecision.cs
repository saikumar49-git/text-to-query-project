using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DocumentArchivalDecision
{
    public int DocumentArchivalDecisionId { get; set; }

    public int? DocumentArchivalProcessId { get; set; }

    public int? DocumentDetailId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual DocumentArchivalProcess? DocumentArchivalProcess { get; set; }

    public virtual DocumentArchivalDetail? DocumentDetail { get; set; }
}
