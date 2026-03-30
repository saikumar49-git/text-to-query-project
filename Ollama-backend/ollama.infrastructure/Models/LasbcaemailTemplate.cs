using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaemailTemplate
{
    public int LasbcaemailTemplateId { get; set; }

    public int? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? EmailNotifiedSubject { get; set; }

    public string? EmailNotifiedTemplate { get; set; }

    public int? StatusNumber { get; set; }
}
