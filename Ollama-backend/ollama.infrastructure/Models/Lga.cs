using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lga
{
    public int Lgaid { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string Lganame { get; set; } = null!;

    public int? StateId { get; set; }

    public int? LocationCategoryId { get; set; }

    public virtual ICollection<City> Cities { get; set; } = new List<City>();

    public virtual ICollection<FencingPermitApplicationDetail> FencingPermitApplicationDetails { get; set; } = new List<FencingPermitApplicationDetail>();

    public virtual ICollection<OwnershipChangeApplicationFormDetail> OwnershipChangeApplicationFormDetails { get; set; } = new List<OwnershipChangeApplicationFormDetail>();

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<RemodelingPermitApplicationDetail> RemodelingPermitApplicationDetails { get; set; } = new List<RemodelingPermitApplicationDetail>();

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual State? State { get; set; }

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
