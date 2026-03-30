using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class BuildingInspection
{
    public int BuildingInspectionId { get; set; }

    public bool? IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ReferenceNumber { get; set; }

    public int? PenaltyFee { get; set; }

    public string? Reason { get; set; }

    public string? Description { get; set; }

    public DateTime? NoticeDate { get; set; }

    public int? Status { get; set; }

    public string? FeePaymentStatus { get; set; }

    public int? Assign { get; set; }

    public string? BuildingAddress { get; set; }

    public string? ViolationType { get; set; }

    public string? ViolationDescription { get; set; }

    public int? ProposedPenaltyFee { get; set; }

    public string? EvidenceOfService { get; set; }

    public string? RequestedDocuments { get; set; }

    public string? NoticeType { get; set; }
}
