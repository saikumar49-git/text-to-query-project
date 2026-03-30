using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingPermitDocumentChecklistDetail
{
    public int FpdocumentChecklistDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int FencingPermitApplicationId { get; set; }

    public int FencingPermitDocumentsChecklistId { get; set; }

    public string? OtherDocumentTypeText { get; set; }

    public virtual FencingPermitApplication FencingPermitApplication { get; set; } = null!;

    public virtual FencingPermitDocumentsChecklist FencingPermitDocumentsChecklist { get; set; } = null!;
}
