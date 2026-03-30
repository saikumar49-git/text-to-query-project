using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteConsumerPolicy
{
    public int WebsiteConsumerPolicyId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? TermsOfUse { get; set; }

    public string? SecurityText { get; set; }

    public string? PrivacyPolicy { get; set; }

    public string? Cancellation { get; set; }
}
