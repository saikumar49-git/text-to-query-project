using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class FoundationBasementComplianceForm
{
    public int FbcomplianceFormId { get; set; }

    public string? Thickness { get; set; }

    public string? Reinforcement { get; set; }

    public string? StrengthAchived { get; set; }

    public string? NatureOfCuring { get; set; }

    public string? GeneralRemarks { get; set; }

    public string? Justification { get; set; }

    public string? BuilderName { get; set; }

    public DateTime? BuilderDate { get; set; }

    public string? StructuralEngineerName { get; set; }

    public DateTime? StructuralEngineerDate { get; set; }

    public string? ArchitectName { get; set; }

    public DateTime? ArchitectDate { get; set; }

    public string? TypeOfForms { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool? ArchitectApproval { get; set; }

    public bool? StructuralEngineerApproval { get; set; }

    public bool? BuilderApproval { get; set; }

    public int? StageCertificationApplicationId { get; set; }

    public string? Signature { get; set; }
}
