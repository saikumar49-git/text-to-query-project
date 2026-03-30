using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyApplication
{
    public int CtcapplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string ApplicationNumber { get; set; } = null!;

    public int ModeOfCtc { get; set; }

    public int AgencyId { get; set; }

    public int RequestServiceId { get; set; }

    public string? SearchCriteria { get; set; }

    public string? Status { get; set; }

    public string? ApprovalNumber { get; set; }

    public string? NameOfDocument { get; set; }

    public string? FirstName { get; set; }

    public string? MiddelName { get; set; }

    public string? LastName { get; set; }

    public int? ArchivalDocumentTypesId { get; set; }

    public string? OtherDocumentTypeText { get; set; }

    public string? OrganizationName { get; set; }

    public int? DistrictId { get; set; }

    public int? DocumentArchivalProcessId { get; set; }

    public virtual ICollection<CertifiedTrueCopyApplicationDetail> CertifiedTrueCopyApplicationDetails { get; set; } = new List<CertifiedTrueCopyApplicationDetail>();

    public virtual ICollection<CertifiedTrueCopyApplicationFile> CertifiedTrueCopyApplicationFiles { get; set; } = new List<CertifiedTrueCopyApplicationFile>();

    public virtual ICollection<CertifiedTrueCopyPayment> CertifiedTrueCopyPayments { get; set; } = new List<CertifiedTrueCopyPayment>();

    public virtual ICollection<CertifiedTrueCopyProcessingFee> CertifiedTrueCopyProcessingFees { get; set; } = new List<CertifiedTrueCopyProcessingFee>();
}
