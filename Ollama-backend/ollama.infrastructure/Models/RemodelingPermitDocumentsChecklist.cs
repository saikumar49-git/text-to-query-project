using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitDocumentsChecklist
{
    public int RemodelingPermitDocumentsChecklistId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentDescription { get; set; }

    public string? SubDocumentName { get; set; }

    public virtual ICollection<RemodelingPermitDocumentChecklistDetail> RemodelingPermitDocumentChecklistDetails { get; set; } = new List<RemodelingPermitDocumentChecklistDetail>();
}
