using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DocumentArchivalProcess
{
    public int DocumentArchivalProcessId { get; set; }

    public string DocumentId { get; set; } = null!;

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RequestServiceId { get; set; }

    public virtual ICollection<DocumentArchivalDecision> DocumentArchivalDecisions { get; set; } = new List<DocumentArchivalDecision>();

    public virtual ICollection<DocumentArchivalDetail> DocumentArchivalDetails { get; set; } = new List<DocumentArchivalDetail>();

    public virtual ICollection<DocumentArchivalFile> DocumentArchivalFiles { get; set; } = new List<DocumentArchivalFile>();
}
