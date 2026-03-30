using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertificationApplicationSmstemplate
{
    public int StageCertificationApplicationSmstemplateId { get; set; }

    public bool? IsActive { get; set; }

    public string SenderId { get; set; } = null!;

    public string? SmsnotificationTemplate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SmsHeader { get; set; }

    public int? StatusNumber { get; set; }
}
