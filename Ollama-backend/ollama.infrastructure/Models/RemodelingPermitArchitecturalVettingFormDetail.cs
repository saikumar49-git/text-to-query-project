using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RemodelingPermitArchitecturalVettingFormDetail
{
    public int RemodelingPermitArchitecturalVettingFormDetailId { get; set; }

    public int? RemodelingPermitApplicationId { get; set; }

    public int? RemodelingPermitApplicationDetailId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public int? DesignerTitle { get; set; }

    public string? DesignerFirstName { get; set; }

    public string? DesignerLastName { get; set; }

    public string? DesignerMiddleName { get; set; }

    public string? DesignerArconregistrationNumber { get; set; }

    public string? DesignerStreet { get; set; }

    public int? DesignerDistrict { get; set; }

    public int? DesignerState { get; set; }

    public int? DesignerCity { get; set; }

    public string? DesignerTelephone { get; set; }

    public int? DesignerTypeOfProposal { get; set; }

    public string? DesignerDate { get; set; }

    public string? NoOfFloors { get; set; }

    public string? SiteLocationDescribed { get; set; }

    public string? ProvisionInAllPublicBuildings { get; set; }

    public string? RequiredLandscapeProvision { get; set; }

    public string? AdequateSetBack { get; set; }

    public string? StaircasePracticable { get; set; }

    public string? NoPracticableCarPark { get; set; }

    public string? ParkingRequired { get; set; }

    public string? ProvisionsOfWalkWay { get; set; }

    public string? FunctionalityOfDesign { get; set; }

    public string? ToiletProvision { get; set; }

    public string? EscapeDoorProvided { get; set; }

    public string? DetailSectionalDrawingForMultiFloor { get; set; }

    public string? FireAssemblyPointAndWaterSprinkler { get; set; }

    public string? NaturalLighting { get; set; }

    public string? CrossVentilation { get; set; }

    public string? IsApproved { get; set; }

    public string? OfficerDate { get; set; }

    public string? OfficerFirstName { get; set; }

    public string? OfficerMiddleName { get; set; }

    public string? OfficerLastName { get; set; }

    public string? ArchitectDecision { get; set; }

    public string? EveryRoom { get; set; }

    public virtual City? DesignerCityNavigation { get; set; }

    public virtual District? DesignerDistrictNavigation { get; set; }

    public virtual State? DesignerStateNavigation { get; set; }

    public virtual UserTitle? DesignerTitleNavigation { get; set; }

    public virtual PlanningPermitApplicationFormType? DesignerTypeOfProposalNavigation { get; set; }

    public virtual RemodelingPermitApplication? RemodelingPermitApplication { get; set; }
}
