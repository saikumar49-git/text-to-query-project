using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AboutU
{
    public int AboutUsId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public bool IsActive { get; set; }

    public string? Vission { get; set; }

    public string? Mission { get; set; }

    public string? History { get; set; }

    public string? Leadership { get; set; }

    public string? WhoIsWho { get; set; }

    public string? AwardsAndRecognization { get; set; }

    public string? Motto { get; set; }
}
