using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RmddecisionDetail
{
    public int RmddecisionDetailId { get; set; }

    public int? Rmdid { get; set; }

    public int? RmddetailId { get; set; }

    public int? UserId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual Rmdapplication? Rmd { get; set; }

    public virtual Rmddetail? Rmddetail { get; set; }
}
