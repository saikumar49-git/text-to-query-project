using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MechanicalVettingFormDetail
{
    public int PlanningPermitMechanicalVettingFormDetailId { get; set; }

    public int? PlanningPermitApplicationId { get; set; }

    public int? PlanningPermitApplicationDetailId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public int? ConsultantTitle { get; set; }

    public string? ConsultantFirstName { get; set; }

    public string? ConsultantMiddleName { get; set; }

    public string? ConsultantLastName { get; set; }

    public string? ConsultantArconregistrationNumber { get; set; }

    public string? ConsultantStreet { get; set; }

    public int? ConsutantDistrict { get; set; }

    public int? ConsutantState { get; set; }

    public int? ConsultantCity { get; set; }

    public int? ConsultantLga { get; set; }

    public string? ConsutantTelephone { get; set; }

    public int? ConsultantTypeOfProposal { get; set; }

    public string? ConsultantDate { get; set; }

    public string? ConsultantEmail { get; set; }

    public string? NoOfFloors { get; set; }

    public string? FireFightingSystem { get; set; }

    public string? SchematicDiagrams { get; set; }

    public string? LiftDetail { get; set; }

    public string? WasteWaterTreatmentPlant { get; set; }

    public string? WaterTreatmentPlant { get; set; }

    public string? AirConditioning { get; set; }

    public string? ServicePipes { get; set; }

    public string? InspectionChambers { get; set; }

    public string? SepticTank { get; set; }

    public string? OtherRelevantDetails { get; set; }

    public string? Comments { get; set; }

    public string? EngineerFirstName { get; set; }

    public string? EngineerMiddleName { get; set; }

    public string? EngineerLastName { get; set; }

    public string? Designation { get; set; }

    public string? EngineerDate { get; set; }

    public string? Signature { get; set; }

    public string? ArchitectDecision { get; set; }
}
