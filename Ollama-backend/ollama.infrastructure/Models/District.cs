using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string DistrictName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string? DistrictCode { get; set; }

    public int? CityId { get; set; }

    public int? ZoneId { get; set; }

    public virtual City? City { get; set; }

    public virtual ICollection<DistrictOfficer> DistrictOfficers { get; set; } = new List<DistrictOfficer>();

    public virtual ICollection<DocumentArchivalDetail> DocumentArchivalDetails { get; set; } = new List<DocumentArchivalDetail>();

    public virtual ICollection<ElectricalVettingFormDetail> ElectricalVettingFormDetails { get; set; } = new List<ElectricalVettingFormDetail>();

    public virtual ICollection<FencingPermitApplicationDetail> FencingPermitApplicationDetails { get; set; } = new List<FencingPermitApplicationDetail>();

    public virtual ICollection<OwnershipChangeApplicationFormDetail> OwnershipChangeApplicationFormDetails { get; set; } = new List<OwnershipChangeApplicationFormDetail>();

    public virtual ICollection<PlanningPermitApplicationDetail> PlanningPermitApplicationDetails { get; set; } = new List<PlanningPermitApplicationDetail>();

    public virtual ICollection<PlanningPermitArchitecturalVettingFormDetail> PlanningPermitArchitecturalVettingFormDetails { get; set; } = new List<PlanningPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<RemodelingElectricalVettingFormDetail> RemodelingElectricalVettingFormDetails { get; set; } = new List<RemodelingElectricalVettingFormDetail>();

    public virtual ICollection<RemodelingPermitApplicationDetail> RemodelingPermitApplicationDetails { get; set; } = new List<RemodelingPermitApplicationDetail>();

    public virtual ICollection<RemodelingPermitArchitecturalVettingFormDetail> RemodelingPermitArchitecturalVettingFormDetails { get; set; } = new List<RemodelingPermitArchitecturalVettingFormDetail>();

    public virtual ICollection<RemodelingStructuralVettingFormDetail> RemodelingStructuralVettingFormDetails { get; set; } = new List<RemodelingStructuralVettingFormDetail>();

    public virtual ICollection<RenovationPermitApplicationDetail> RenovationPermitApplicationDetails { get; set; } = new List<RenovationPermitApplicationDetail>();

    public virtual ICollection<StructuralVettingFormDetail> StructuralVettingFormDetails { get; set; } = new List<StructuralVettingFormDetail>();

    public virtual ICollection<User> Users { get; set; } = new List<User>();
}
