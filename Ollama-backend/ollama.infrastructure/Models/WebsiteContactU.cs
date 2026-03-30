using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteContactU
{
    public int WebsiteContactUsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? GetInTouchText { get; set; }

    public string? HeadOfficeAddress { get; set; }

    public string? PhoneNumbers { get; set; }

    public string? EmailAddress { get; set; }
}
