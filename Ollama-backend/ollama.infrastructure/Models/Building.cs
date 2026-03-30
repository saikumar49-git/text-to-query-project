using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Building
{
    public int BuildingInspectionId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? BuildingAddress { get; set; }

    public string? ContraventionRefNumber { get; set; }

    public string? ViolationType { get; set; }

    public string? ViolationDescription { get; set; }

    public int? ProposedPenaltyFee { get; set; }

    public string? EvidenceOfService { get; set; }

    public string? RequestedDocuments { get; set; }

    public string? NoticeType { get; set; }
}
