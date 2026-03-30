using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ProfessionalSupervisingConsultant
{
    public int SupervisingConsultantId { get; set; }

    public string? Cvupload { get; set; }

    public string? SwornAffidavitsUpload { get; set; }

    public string? PractiseLicenseUpload { get; set; }

    public int? UserId { get; set; }

    public string? ProfessionalId { get; set; }

    public virtual User? User { get; set; }
}
