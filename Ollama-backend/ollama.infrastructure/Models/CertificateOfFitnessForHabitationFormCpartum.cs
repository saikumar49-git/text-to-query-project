using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertificateOfFitnessForHabitationFormCpartum
{
    public int CertificateOfFitnessForHabitationFormCpartAid { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StageCertificationApplicationId { get; set; }

    public string? OwnerName { get; set; }

    public string? OwnerAddress { get; set; }

    public string? ContractorName { get; set; }

    public string? ContractorTelephone { get; set; }

    public string? ContractorAddress { get; set; }

    public string? ContractorRegName { get; set; }

    public string? BuilderName { get; set; }

    public string? BuilderTelephone { get; set; }

    public string? BuilderAddress { get; set; }

    public string? BuilderRegisterNo { get; set; }

    public string? SupervisingEngineerName { get; set; }

    public string? SupervisingEngineerRegNo { get; set; }

    public string? SupervisingEngineerAddress { get; set; }

    public string? SupervisingEngineerTelephone { get; set; }

    public string? SupervisingArchitectName { get; set; }

    public string? SupervisingArchitectRegNo { get; set; }

    public string? PlanningPermitNumber { get; set; }

    public string? SiteOrLocationofDevelopment { get; set; }

    public string? DimensionsAndSizeOfPlot { get; set; }

    public string? PredominantLandUseInTheArea { get; set; }

    public string? NoOfStructuresOnSite { get; set; }

    public string? NoOfStructuresUnderConstructionOnSite { get; set; }

    public string? NoOfFloors { get; set; }

    public string? HeightOfStructure { get; set; }

    public string? GrossFloorArea { get; set; }

    public string? IfCommercialNoOfFlats { get; set; }

    public string? TypesOfDevelopment { get; set; }

    public string? TypesOfDevelopmentIfResidentialStateTypeandNoOfUnitsAndRoomsPerUnit { get; set; }

    public string? TypesOfDevelopmentIfResidentialRoomingHouseStateNoOfRooms { get; set; }

    public string? TypesOfDevelopmentIfCommercialStatesTheActualPurpose { get; set; }

    public string? TypesOfDevelopmentIfInstitutionalStateTheActualPurpose { get; set; }

    public string? TypesOfDevelopmentIfPlaceOfWorshipStateTypeAndExpectedCapacity { get; set; }

    public string? TypesOfDevelopmentIfIndustrialStateTheActualPurpose { get; set; }

    public string? TypesOfDevelopmentIfRecreationalstateActualPurpose { get; set; }

    public string? TypesOfDevelopmentIfOthersStateActualPurpose { get; set; }

    public int? RequestServiceId { get; set; }
}
