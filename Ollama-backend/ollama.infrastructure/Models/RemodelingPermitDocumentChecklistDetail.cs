using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitDocumentChecklistDetail
{
    public int PpdocumentChecklistDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int RemodelingPermitApplicationDetailId { get; set; }

    public int RemodelingPermitDocumentsChecklistId { get; set; }

    public virtual RemodelingPermitApplicationDetail RemodelingPermitApplicationDetail { get; set; } = null!;

    public virtual RemodelingPermitDocumentsChecklist RemodelingPermitDocumentsChecklist { get; set; } = null!;
}
