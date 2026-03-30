using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitDocumentChecklistDetail
{
    public int PpdocumentChecklistDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int PlanningPermitApplicationDetailId { get; set; }

    public int PlanningPermitDocumentsChecklistId { get; set; }

    public string? OtherDocumentTypeText { get; set; }

    public virtual PlanningPermitApplicationDetail PlanningPermitApplicationDetail { get; set; } = null!;

    public virtual PlanningPermitDocumentsChecklist PlanningPermitDocumentsChecklist { get; set; } = null!;
}
