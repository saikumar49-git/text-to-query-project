using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyApplicationStatus
{
    public int CtcstatusId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RequestServiceId { get; set; }

    public int StatusNumber { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public virtual ICollection<CertifiedTrueCopyApplicationDetail> CertifiedTrueCopyApplicationDetails { get; set; } = new List<CertifiedTrueCopyApplicationDetail>();

    public virtual ICollection<CertifiedTrueCopyPayment> CertifiedTrueCopyPayments { get; set; } = new List<CertifiedTrueCopyPayment>();

    public virtual RequestService? RequestService { get; set; }
}
