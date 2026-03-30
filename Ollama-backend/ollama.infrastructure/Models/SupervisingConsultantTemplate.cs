using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SupervisingConsultantTemplate
{
    public int SupervisingConsultantTemplateId { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? EmailNotifiedSubject { get; set; }

    public string? EmailNotifiedTemplate { get; set; }

    public int? StatusNumber { get; set; }
}
