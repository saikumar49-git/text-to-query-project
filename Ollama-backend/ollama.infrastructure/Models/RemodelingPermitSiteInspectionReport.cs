using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitSiteInspectionReport
{
    public int RemodelingSiteInspectionReportId { get; set; }

    public int? RemodelingPermitId { get; set; }

    public int? RemodelingPermitDetailId { get; set; }

    public bool? IsActive { get; set; }

    public int? SubmittedBy { get; set; }

    public DateTime? SubmittedDates { get; set; }

    public string? PlanNumber { get; set; }

    public string? LocationOfProposal { get; set; }

    public string? TypeOfProposal { get; set; }

    public string? SubjectSite { get; set; }

    public string? SiteVacancy { get; set; }

    public string? FrontSetBackProposal { get; set; }

    public string? RearAirspaceProposal { get; set; }

    public string? RightAirspaceProposal { get; set; }

    public string? LeftAirspaceProposal { get; set; }

    public string? DrawingSubmittion { get; set; }

    public string? Variance { get; set; }

    public string? BuildingDimensions { get; set; }

    public string? OrientationSite { get; set; }

    public string? AvailabilityofDrainage { get; set; }

    public string? AccessToProposal { get; set; }

    public string? MotorableRoad { get; set; }

    public string? ExistingAccessPrimary { get; set; }

    public string? ExistingAccessSecondary { get; set; }

    public string? ExistingAccessTertiary { get; set; }

    public string? ExistingAccessOthers { get; set; }

    public string? AdjacentPlots { get; set; }

    public string? SiteUnderConsidertaion { get; set; }

    public string? NoExistingBuildings { get; set; }

    public string? HighDevelopmentNearSite { get; set; }

    public string? HighDevelomentFloors { get; set; }

    public string? SurfaceWaterApproval { get; set; }

    public string? SurfaceWaterObjection { get; set; }

    public string? BuildingWill { get; set; }

    public string? AcquistionType { get; set; }

    public string? NameofAcquistion { get; set; }

    public string? LayoutApproval { get; set; }

    public string? LayoutRejected { get; set; }

    public string? ZoningOfArea { get; set; }

    public string? PublicDrainage { get; set; }

    public string? PublicElectricityTransmissionLines { get; set; }

    public string? PublicWaterMains { get; set; }

    public string? PublicRailwayMain { get; set; }

    public string? PublicNnpc { get; set; }

    public string? PublicOthers { get; set; }

    public string? NaturalWaterbodies { get; set; }

    public string? NaturalCanals { get; set; }

    public string? NaturalGorge { get; set; }

    public string? NaturalOthers { get; set; }

    public string? ProximitySchools { get; set; }

    public string? ProximityPos { get; set; }

    public string? ProximityHealthCenter { get; set; }

    public string? ProximityOthers { get; set; }

    public string? NameOfOfficer { get; set; }

    public string? Designation { get; set; }

    public string? Signature { get; set; }

    public DateTime? DateOfSubmittion { get; set; }
}
