using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertificateOfFitnessForHabitationFormCpartB
{
    public int CertificateOfFitnessForHabitationFormCpartBid { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StageCertificationApplicationId { get; set; }

    public string? TypesOfAccess { get; set; }

    public string? TypesOfAccessVehicular { get; set; }

    public string? TypesOfAccessVehicularWidthMeters { get; set; }

    public string? TypesOfAccessPedestrian { get; set; }

    public string? TypesOfAccessPedestrianWidthMeters { get; set; }

    public string? TypesOfAccessOthers { get; set; }

    public string? TypesOfAccessOthersWidthMeters { get; set; }

    public string? ActualSetbackFrom { get; set; }

    public string? ActualSetbackFromMeters { get; set; }

    public string? ActualSetbackFromAccessRoad { get; set; }

    public string? ActualSetbackFromAccessRoadMeters { get; set; }

    public string? ActualSetbackFromCanalDrains { get; set; }

    public string? ActualSetbackFromCanalDrainsMeters { get; set; }

    public string? ActualSetbackFromWaterBody { get; set; }

    public string? ActualSetbackFromWaterBodyMeters { get; set; }

    public string? ActualSetbackFromPhcnhighTensionLines { get; set; }

    public string? ActualSetbackFromPhcnhighTensionLinesMeters { get; set; }

    public string? ActualSetbackNnpcinstallationsPipelines { get; set; }

    public string? ActualSetbackNnpcinstallationsPipelinesMeters { get; set; }

    public string? ActualSetbackOthers { get; set; }

    public string? ActualSetbackOthersMeters { get; set; }

    public string? ActualAirSpaceOnFront { get; set; }

    public string? ActualAirSpaceOnFrontMeters { get; set; }

    public string? ActualAirSpaceOnRear { get; set; }

    public string? ActualAirSpaceOnRearMeters { get; set; }

    public string? ActualAirSpaceOnRightSide { get; set; }

    public string? ActualAirSpaceOnRightSideMeters { get; set; }

    public string? ActualAirSpaceOnLeftSide { get; set; }

    public string? ActualAirSpaceOnLeftSideMeters { get; set; }

    public bool? AvailabilityOfPublicUtilitiesDrainageNetwork { get; set; }

    public bool? AvailabilityOfPublicUtilitiesWaterSupplyOrBorehole { get; set; }

    public bool? AvailabilityOfPublicUtilitiesElectricity { get; set; }

    public bool? AvailabilityOfPublicUtilitiesTelephone { get; set; }

    public bool? AvailabilityOfPublicUtilitiesRefuseDisposal { get; set; }

    public string? ProjectManagerOwner { get; set; }

    public string? ProjectArea { get; set; }

    public DateTime? SupervisingArchitectDate { get; set; }

    public string? SupervisingStructuralEngineer { get; set; }

    public DateTime? SupervisingStructuralEngineerDate { get; set; }

    public DateTime? RegisterBuilderDate { get; set; }

    public DateTime? ContactorDate { get; set; }

    public int? RequestServiceId { get; set; }
}
