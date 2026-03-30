using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AuthorizationToCommenceConstruction
{
    public int AuthorizationToCommenceConstructionId { get; set; }

    public string? Officeofissue { get; set; }

    public string? Developer { get; set; }

    public string? Address { get; set; }

    public string? Location { get; set; }

    public string? Day { get; set; }

    public DateOnly? Date { get; set; }

    public string? DatedDay { get; set; }

    public DateOnly? DatedOn { get; set; }

    public int? StageCertificationApplicationId { get; set; }
}
