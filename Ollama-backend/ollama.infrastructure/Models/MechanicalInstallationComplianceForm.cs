using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class MechanicalInstallationComplianceForm
{
    public int MicformId { get; set; }

    public string? ProjectTitle { get; set; }

    public string? OwnerFirstName { get; set; }

    public string? OwnerMiddleName { get; set; }

    public string? OwnerLastName { get; set; }

    public string? OwnerAddress { get; set; }

    public string? SiteLocation { get; set; }

    public string? PlotNo { get; set; }

    public string? Operations { get; set; }

    public string? FormNumber { get; set; }

    public string? Address { get; set; }

    public int? StateId { get; set; }

    public int? Lgaid { get; set; }

    public int? CityId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StageCertificationApplicationId { get; set; }
}
