using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class AuthorizationToLasbcademolition
{
    public int AuthorizationToLasbcademolitionId { get; set; }

    public string? OfficeofIssue { get; set; }

    public string? Developer { get; set; }

    public string? Address { get; set; }

    public string? Location { get; set; }

    public string? Day { get; set; }

    public DateTime? Date { get; set; }

    public string? DatedDay { get; set; }

    public DateTime? DatedDate { get; set; }

    public int? DemolitionPermitId { get; set; }
}
