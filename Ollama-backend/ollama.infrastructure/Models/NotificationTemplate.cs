using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class NotificationTemplate
{
    public int NotificationTemplateId { get; set; }

    public string NotificationKey { get; set; } = null!;

    public string? Description { get; set; }

    public string? EmailSubject { get; set; }

    public string? EmailTemplate { get; set; }

    public string? Smstemplate { get; set; }

    public int? RequestServiceId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
