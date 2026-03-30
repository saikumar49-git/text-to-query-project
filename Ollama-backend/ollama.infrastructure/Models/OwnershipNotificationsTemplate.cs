using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class OwnershipNotificationsTemplate
{
    public int OwnershipNotificationTemplateId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string NotificationTypeCode { get; set; } = null!;

    public string EmailNotificationSubject { get; set; } = null!;

    public string EmailNotificationTemplate { get; set; } = null!;

    public string SmsnotificationTemplate { get; set; } = null!;
}
