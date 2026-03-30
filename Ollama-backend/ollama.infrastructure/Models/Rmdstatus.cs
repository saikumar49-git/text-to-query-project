using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Rmdstatus
{
    public int RmdstatusId { get; set; }

    public int? StatusNumber { get; set; }

    public string? StatusName { get; set; }

    public string? StatusMessage { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual ICollection<Rmddetail> Rmddetails { get; set; } = new List<Rmddetail>();

    public virtual ICollection<Rmdpayment> Rmdpayments { get; set; } = new List<Rmdpayment>();
}
