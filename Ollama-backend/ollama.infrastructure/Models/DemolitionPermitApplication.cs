using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionPermitApplication
{
    public int DemolitionPermitId { get; set; }

    public string ApplicationNumber { get; set; } = null!;

    public int RequestServiceId { get; set; }

    public string? PermitNumber { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? DemolitionPermitNumber { get; set; }

    public DateTime? DemolitionPermitNumberCreatedOn { get; set; }

    public bool IsPermitNumberVerified { get; set; }

    public bool? IsPermitApplicationValid { get; set; }

    public bool IsApplicationRejected { get; set; }

    public string? PropertyLocationDetail { get; set; }

    public virtual ICollection<DemolitionPermitApplicationDetail> DemolitionPermitApplicationDetails { get; set; } = new List<DemolitionPermitApplicationDetail>();

    public virtual ICollection<DemolitionPermitApplicationFile> DemolitionPermitApplicationFiles { get; set; } = new List<DemolitionPermitApplicationFile>();

    public virtual ICollection<DemolitionPermitDecision> DemolitionPermitDecisions { get; set; } = new List<DemolitionPermitDecision>();

    public virtual ICollection<DemolitionPermitPayment> DemolitionPermitPayments { get; set; } = new List<DemolitionPermitPayment>();

    public virtual RequestService RequestService { get; set; } = null!;
}
