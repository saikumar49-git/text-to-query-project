using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ArchivalDocumentType
{
    public int ArchivalDocumentTypesId { get; set; }

    public bool IsActive { get; set; }

    public string? DoumentType { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<DocumentArchivalDetail> DocumentArchivalDetails { get; set; } = new List<DocumentArchivalDetail>();

    public virtual ICollection<SearchProcessApplication> SearchProcessApplications { get; set; } = new List<SearchProcessApplication>();
}
