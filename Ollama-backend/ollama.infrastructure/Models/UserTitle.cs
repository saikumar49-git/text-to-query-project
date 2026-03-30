using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserTitle
{
    public int TitleId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? TitleName { get; set; }

    public bool? IsVisibleInVetting { get; set; }

    public bool? IsVisibleInOtherForms { get; set; }

    public virtual ICollection<ElectricalVettingFormDetail> ElectricalVettingFormDetails { get; set; } = new List<ElectricalVettingFormDetail>();

    public virtual ICollection<FencingPermitApplicationFormDetail> FencingPermitApplicationFormDetails { get; set; } = new List<FencingPermitApplicationFormDetail>();

    public virtual ICollection<FencingStructuralVettingFormDetail> FencingStructuralVettingFormDetails { get; set; } = new List<FencingStructuralVettingFormDetail>();

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<PlanningPermitApplicationFormDetail> PlanningPermitApplicationFormDetails { get; set; } = new List<PlanningPermitApplicationFormDetail>();

    public virtual ICollection<PlanningPermitArchitecturalVettingFormDetail> PlanningPermitArchitecturalVettingFormDetails { get; set; } = new List<PlanningPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<RemodelingElectricalVettingFormDetail> RemodelingElectricalVettingFormDetails { get; set; } = new List<RemodelingElectricalVettingFormDetail>();

    public virtual ICollection<RemodelingPermitApplicationDetail> RemodelingPermitApplicationDetails { get; set; } = new List<RemodelingPermitApplicationDetail>();

    public virtual ICollection<RemodelingPermitArchitecturalVettingFormDetail> RemodelingPermitArchitecturalVettingFormDetails { get; set; } = new List<RemodelingPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<RemodelingStructuralVettingFormDetail> RemodelingStructuralVettingFormDetails { get; set; } = new List<RemodelingStructuralVettingFormDetail>();

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual ICollection<StructuralVettingFormDetail> StructuralVettingFormDetails { get; set; } = new List<StructuralVettingFormDetail>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
