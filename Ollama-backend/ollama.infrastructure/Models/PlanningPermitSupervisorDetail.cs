using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class PlanningPermitSupervisorDetail
{
    public int PlanningPermitSupervisorDetailsId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int PlanningPermitApplicationId { get; set; }

    public string? SupervisingEngineerFirm { get; set; }

    public string? ContactPerson { get; set; }

    public string? PhoneNumber { get; set; }

    public string? Email { get; set; }

    public string? ContactAddress { get; set; }

    public string? Corennumber { get; set; }

    public virtual PlanningPermitApplication PlanningPermitApplication { get; set; } = null!;
}
