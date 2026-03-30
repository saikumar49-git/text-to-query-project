using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class RoofingClosingUpComplianceForm
{
    public int RoofingClosingUpComplianceFormId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StageCertificationApplicationId { get; set; }

    public string? Windows { get; set; }

    public string? ExternalDoors { get; set; }

    public string? NameOfEngineer { get; set; }

    public string? DateOfSubmission { get; set; }

    public string? ApprovalOfEngineer { get; set; }

    public string? Signatures { get; set; }
}
