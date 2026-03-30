using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaprocessApplication
{
    public int ApplicationId { get; set; }

    public int? AuthorizationCommenceId { get; set; }

    public string? PermitNumber { get; set; }

    public string? ApplicationNumber { get; set; }

    public int? StatusId { get; set; }

    public int? StageId { get; set; }

    public int RequestServiceId { get; set; }

    public int? AgencyId { get; set; }

    public int CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool IsActive { get; set; }
}
