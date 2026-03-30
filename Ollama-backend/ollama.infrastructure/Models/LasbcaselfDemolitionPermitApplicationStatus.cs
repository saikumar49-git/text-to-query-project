using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaselfDemolitionPermitApplicationStatus
{
    public int DemolitionPermitStatusId { get; set; }

    public int StatusNumber { get; set; }

    public string StatusName { get; set; } = null!;

    public string? StatusMessage { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<DemolitionApplicationBySelfDetail> DemolitionApplicationBySelfDetails { get; set; } = new List<DemolitionApplicationBySelfDetail>();

    public virtual ICollection<LasbcademolitionPayment> LasbcademolitionPayments { get; set; } = new List<LasbcademolitionPayment>();
}
