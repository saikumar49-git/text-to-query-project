using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Applicationvettingform
{
    public string? PlanningPermitNumber { get; set; }

    public string? ApplicantName { get; set; }

    public string? Location { get; set; }

    public string? Accessibility { get; set; }

    public string? ZoningUse { get; set; }

    public string? ProposedUse { get; set; }

    public string? TypeofUse { get; set; }

    public string? SurveyPlanNumber { get; set; }

    public DateTime? SurveyPlanDate { get; set; }

    public string? TypeofInterest { get; set; }

    public string? ProofofOwnership { get; set; }

    public string? AreaofPlots { get; set; }

    public string? PermissibleUnit { get; set; }

    public string? PermissibleProposed { get; set; }

    public string? TotalFloorArea { get; set; }

    public string? PermissibleUnitArea { get; set; }

    public string? TotalLettableFloorArea { get; set; }

    public string? PlotCoveragePermissible { get; set; }

    public string? PlotCoverageProposed { get; set; }

    public string? ParkingPermissible { get; set; }

    public string? ParkingProposed { get; set; }

    public string? SetBackFrontPermissible { get; set; }

    public string? SetBackFrontProposed { get; set; }

    public string? SetBackRearPermissible { get; set; }

    public string? SetBackRearProposed { get; set; }

    public string? SetBackLeftPermissible { get; set; }

    public string? SetBackLeftProposed { get; set; }

    public string? SetBackRightPermissible { get; set; }

    public string? SetBackRightProposed { get; set; }

    public string? DetailsofDevelopment { get; set; }

    public string? SiteReport { get; set; }

    public string? Vacant { get; set; }

    public string? Nonvacant { get; set; }

    public string? EiaorPptrreport { get; set; }

    public string? Tiareport { get; set; }

    public string? Mdareport { get; set; }

    public string? LetterofEngineer { get; set; }

    public string? ProposingFee { get; set; }

    public string? PenalFee { get; set; }

    public string? Idcfee { get; set; }

    public string? ApplicantTcc { get; set; }

    public string? DirectorTcc { get; set; }

    public string? DevelopmentLevy { get; set; }

    public string? EvidenceofPayeeReturn { get; set; }

    public string? CertificateofIncorporation { get; set; }

    public string? EvidenceofTenement { get; set; }

    public string? Luacletter { get; set; }

    public string? OutStandingDocuments { get; set; }

    public string? VettingOfficersRemark { get; set; }

    public string? VettingOfficerName { get; set; }

    public string? VettingOfficerDesignation { get; set; }

    public string? VettingOfficerSignature { get; set; }

    public DateTime? VettingOfficerActionDate { get; set; }

    public string? RecommendingOfficerRemarks { get; set; }

    public string? RecommendationStamp { get; set; }

    public string? NameofRecommendationOfficer { get; set; }

    public string? DesignationofRecommendationOfficer { get; set; }

    public DateTime? AccountantClearanceDate { get; set; }

    public string? ApplicantNo { get; set; }

    public int? SubmittedBy { get; set; }

    public DateTime? SubmittedOn { get; set; }

    public int ApplicationVettingFormId { get; set; }
}
