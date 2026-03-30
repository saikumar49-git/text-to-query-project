using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionPermitApplicationStatus
{
    public int DemolitionPermitStatusId { get; set; }

    public int StatusNumber { get; set; }

    public string StatusName { get; set; } = null!;

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? StatusMessage { get; set; }

    public virtual ICollection<DemolitionPermitApplicationDetail> DemolitionPermitApplicationDetails { get; set; } = new List<DemolitionPermitApplicationDetail>();

    public virtual ICollection<DemolitionPermitPayment> DemolitionPermitPayments { get; set; } = new List<DemolitionPermitPayment>();
}
