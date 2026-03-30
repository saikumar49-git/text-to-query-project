using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class DemolitionPermitApplicationDetail
{
    public int DemolitionPermitDetailId { get; set; }

    public int? DemolitionPermitId { get; set; }

    public int? DemolitionPermitStatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual DemolitionPermitApplication? DemolitionPermit { get; set; }

    public virtual ICollection<DemolitionPermitDecision> DemolitionPermitDecisions { get; set; } = new List<DemolitionPermitDecision>();

    public virtual DemolitionPermitApplicationStatus? DemolitionPermitStatus { get; set; }
}
