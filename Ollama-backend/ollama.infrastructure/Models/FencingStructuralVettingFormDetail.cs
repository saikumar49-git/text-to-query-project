using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FencingStructuralVettingFormDetail
{
    public int FencingStructuralVettingFormDetailId { get; set; }

    public int? FencingPermitApplicationId { get; set; }

    public int? FencingPermitApplicationDetailId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

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

    public bool? SubSoilInvestigation { get; set; }

    public bool? CalculationSheets { get; set; }

    public bool? StructuralDrawing { get; set; }

    public bool? LetterStructuralStability { get; set; }

    public bool? ComprehensiveStrengthTest { get; set; }

    public string? EnginerFirstName { get; set; }

    public string? EnginerMiddleName { get; set; }

    public string? EnginerLastName { get; set; }

    public string? EnginerDesignation { get; set; }

    public string? EnginerDate { get; set; }

    public bool? ArchitectDecision { get; set; }

    public virtual City? ConsultantCityNavigation { get; set; }

    public virtual State? ConsultantStateNavigation { get; set; }

    public virtual UserTitle? ConsultantTitleNavigation { get; set; }

    public virtual PlanningPermitApplicationFormType? ConsultantTypeOfProposalNavigation { get; set; }

    public virtual FencingPermitApplication? FencingPermitApplication { get; set; }

    public virtual FencingPermitApplicationDetail? FencingPermitApplicationDetail { get; set; }
}
