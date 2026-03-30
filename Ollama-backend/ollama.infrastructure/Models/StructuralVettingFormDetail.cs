using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StructuralVettingFormDetail
{
    public int StructuralVettingFormDetailId { get; set; }

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

    public string? NatureOfSoil { get; set; }

    public string? SubSoilInvestigation { get; set; }

    public string? CalculationSheets { get; set; }

    public string? StructuralDrawing { get; set; }

    public string? LetterStructuralStability { get; set; }

    public string? ComprehensiveStrengthTest { get; set; }

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
