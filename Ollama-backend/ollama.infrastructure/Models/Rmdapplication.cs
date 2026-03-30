using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Rmdapplication
{
    public int Rmdid { get; set; }

    public string? ApplicationNumber { get; set; }

    public int RequestServiceId { get; set; }

    public string? RmdpermitNumber { get; set; }

    public int? PreferredFormat { get; set; }

    public bool? PlanCopyDownloaded { get; set; }

    public DateTime? RmdpermitNumberCreatedOn { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? RmdmapDetailsId { get; set; }

    public virtual RequestService RequestService { get; set; } = null!;

    public virtual ICollection<RmddecisionDetail> RmddecisionDetails { get; set; } = new List<RmddecisionDetail>();

    public virtual ICollection<Rmddetail> Rmddetails { get; set; } = new List<Rmddetail>();

    public virtual ICollection<Rmdfile> Rmdfiles { get; set; } = new List<Rmdfile>();

    public virtual ICollection<Rmdpayment> Rmdpayments { get; set; } = new List<Rmdpayment>();

    public virtual ICollection<RmdrequestForm> RmdrequestForms { get; set; } = new List<RmdrequestForm>();
}
