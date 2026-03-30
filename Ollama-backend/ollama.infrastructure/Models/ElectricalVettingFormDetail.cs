using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ElectricalVettingFormDetail
{
    public int ElectricalVettingFormDetailId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitApplicationDetailId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public int? ConsultantTitle { get; set; }

    public string? ConsultantFirstName { get; set; }

    public string? ConsultantLastName { get; set; }

    public string? ConsultantMiddleName { get; set; }

    public string? ConsultantArconregistrationNumber { get; set; }

    public string? ConsultantStreet { get; set; }

    public int? ConsultantDistrict { get; set; }

    public int? ConsultantState { get; set; }

    public int? ConsultantCity { get; set; }

    public string? ConsultantTelephone { get; set; }

    public string? ConsultantDate { get; set; }

    public string? ConsultantEmail { get; set; }

    public int? ConsultantTypeOfProposal { get; set; }

    public string? NoOfFloors { get; set; }

    public string? CablingSystem { get; set; }

    public string? FireDetectionSystem { get; set; }

    public string? LightingLayout { get; set; }

    public string? PowerLayout { get; set; }

    public string? SchematicDiagram { get; set; }

    public string? LoadEstimation { get; set; }

    public string? LightningProtection { get; set; }

    public string? OtherRelevantDetails { get; set; }

    public string? Comments { get; set; }

    public string? EnginerFirstName { get; set; }

    public string? EnginerMiddleName { get; set; }

    public string? EnginerLastName { get; set; }

    public string? EnginerDesignation { get; set; }

    public string? EnginerDate { get; set; }

    public string? ArchitectDecision { get; set; }

    public virtual City? ConsultantCityNavigation { get; set; }

    public virtual District? ConsultantDistrictNavigation { get; set; }

    public virtual State? ConsultantStateNavigation { get; set; }

    public virtual UserTitle? ConsultantTitleNavigation { get; set; }

    public virtual PlanningPermitApplicationFormType? ConsultantTypeOfProposalNavigation { get; set; }

    public virtual PlanningPermitApplication? PlanningPermitApplication { get; set; }

    public virtual PlanningPermitApplicationDetail? PlanningPermitApplicationDetail { get; set; }
}
