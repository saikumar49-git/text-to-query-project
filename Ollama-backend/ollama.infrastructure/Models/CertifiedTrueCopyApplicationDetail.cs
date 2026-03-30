using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyApplicationDetail
{
    public int CtcapplicationDetailId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CtcapplicationId { get; set; }

    public int? CtcstatusId { get; set; }

    public string? Hodcomments { get; set; }

    public string? Pscomments { get; set; }

    public string? Aocomments { get; set; }

    public string? Hoddecision { get; set; }

    public string? Psdecision { get; set; }

    public string? Aodecision { get; set; }

    public int? AssignedOfficerUid { get; set; }

    public string? Status { get; set; }

    public bool? IsDocumentFound { get; set; }

    public virtual ICollection<CertifiedTrueCopyProcessingFee> CertifiedTrueCopyProcessingFees { get; set; } = new List<CertifiedTrueCopyProcessingFee>();

    public virtual CertifiedTrueCopyApplication? Ctcapplication { get; set; }

    public virtual CertifiedTrueCopyApplicationStatus? Ctcstatus { get; set; }
}
