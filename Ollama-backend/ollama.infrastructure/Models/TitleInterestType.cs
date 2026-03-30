using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class TitleInterestType
{
    public int TitleInterestTypeId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? TitleInterestTypeName { get; set; }

    public virtual ICollection<FencingPermitApplicationFormDetail> FencingPermitApplicationFormDetails { get; set; } = new List<FencingPermitApplicationFormDetail>();

    public virtual ICollection<PlanningPermitApplicationFormDetail> PlanningPermitApplicationFormDetails { get; set; } = new List<PlanningPermitApplicationFormDetail>();
}
