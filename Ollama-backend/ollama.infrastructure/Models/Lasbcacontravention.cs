using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcacontravention
{
    public int ContraventionId { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public int? RequestServiceId { get; set; }

    public string? ReferenceNumber { get; set; }

    public int? Penalty { get; set; }

    public int? UserId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? PaymentStatus { get; set; }

    public bool IsActive { get; set; }

    public int? AddressId { get; set; }

    public string? EvidenceOfServiceId { get; set; }

    public int? NoticeTypeId { get; set; }

    public string? ViolationDescription { get; set; }

    public string? RequestedDocs { get; set; }

    public DateTime? ExpiryDate { get; set; }

    public string? ApplicationNumber { get; set; }

    public bool? IsIndividual { get; set; }

    public string? ViolationTypeId { get; set; }

    public string? TypeOfStructure { get; set; }

    public string? Developer { get; set; }
}
