using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class WebsiteFaq
{
    public int WebsiteFaqid { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? Faqcatogory { get; set; }

    public string? Question { get; set; }

    public string? Answer { get; set; }
}
