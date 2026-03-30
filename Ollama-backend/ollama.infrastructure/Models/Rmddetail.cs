using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Rmddetail
{
    public int RmddetailId { get; set; }

    public int? Rmdid { get; set; }

    public int? RmdstatusId { get; set; }

    public string? Status { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Rmdapplication? Rmd { get; set; }

    public virtual ICollection<RmddecisionDetail> RmddecisionDetails { get; set; } = new List<RmddecisionDetail>();

    public virtual Rmdstatus? Rmdstatus { get; set; }
}
