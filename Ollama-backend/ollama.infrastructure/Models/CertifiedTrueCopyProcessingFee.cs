using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyProcessingFee
{
    public int CtcfeeId { get; set; }

    public int? CtcapplicationId { get; set; }

    public int? CtcapplicationDetailId { get; set; }

    public string? Amount { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? CtcstatusId { get; set; }

    public virtual CertifiedTrueCopyApplication? Ctcapplication { get; set; }

    public virtual CertifiedTrueCopyApplicationDetail? CtcapplicationDetail { get; set; }
}
