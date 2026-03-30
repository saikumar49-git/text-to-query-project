using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertificationSupervisingConsultant
{
    public int StageCertificationSupervisingConsultantId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? ElectricalEngineer { get; set; }

    public int? MechanicalEngineer { get; set; }

    public int? StructuralEngineer { get; set; }

    public int? Architect { get; set; }

    public int? Builder { get; set; }

    public int? ElectricalEngineerStatus { get; set; }

    public int? MechanicalEngineerStatus { get; set; }

    public int? StructuralEngineerStatus { get; set; }

    public int? ArchitectStatus { get; set; }

    public int? BuilderStatus { get; set; }

    public int? StatusNumber { get; set; }

    public string? PlanningPermitNumber { get; set; }

    public string? StatusMessage { get; set; }
}
