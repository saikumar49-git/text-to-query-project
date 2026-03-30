using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcademolitionApplicationBySelf
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

    public bool? IsByLasbca { get; set; }

    public virtual ICollection<DemolitionApplicationBySelfDetail> DemolitionApplicationBySelfDetails { get; set; } = new List<DemolitionApplicationBySelfDetail>();

    public virtual ICollection<DemolitionApplicationBySelfFile> DemolitionApplicationBySelfFiles { get; set; } = new List<DemolitionApplicationBySelfFile>();

    public virtual ICollection<LasbcademolitionApplicationBySelfDetail> LasbcademolitionApplicationBySelfDetails { get; set; } = new List<LasbcademolitionApplicationBySelfDetail>();

    public virtual ICollection<LasbcademolitionPayment> LasbcademolitionPayments { get; set; } = new List<LasbcademolitionPayment>();

    public virtual RequestService RequestService { get; set; } = null!;
}
