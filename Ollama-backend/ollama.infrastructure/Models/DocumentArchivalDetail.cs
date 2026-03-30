using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DocumentArchivalDetail
{
    public int DocumentDetailId { get; set; }

    public int DocumentArchivalProcessId { get; set; }

    public int ArchivalDocumentTypesId { get; set; }

    public string? NameOfDocument { get; set; }

    public string? ApprovalNumber { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? DistrictId { get; set; }

    public string? ProcessingFee { get; set; }

    public string? Status { get; set; }

    public string? Comment { get; set; }

    public string? UserDecision { get; set; }

    public int? ApprovedBy { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? OtherDocumentTypeText { get; set; }

    public bool IsGovernmentUser { get; set; }

    public int? RequestServiceId { get; set; }

    public string? OrganizationName { get; set; }

    public bool? IsOtherModuleArchival { get; set; }

    public int? ApplicantTitleOwnerClassId { get; set; }

    public virtual ArchivalDocumentType ArchivalDocumentTypes { get; set; } = null!;

    public virtual District? District { get; set; }

    public virtual ICollection<DocumentArchivalDecision> DocumentArchivalDecisions { get; set; } = new List<DocumentArchivalDecision>();

    public virtual DocumentArchivalProcess DocumentArchivalProcess { get; set; } = null!;
}
