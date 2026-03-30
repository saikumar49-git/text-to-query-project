using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcaauthorizationCommence
{
    public int AuthorizationCommenceId { get; set; }

    public int? RequestServiceId { get; set; }

    public int? NoOfFloors { get; set; }

    public int? TypeOfCommence { get; set; }

    public int? TypeOfPermit { get; set; }

    public int? UserId { get; set; }

    public string? PermitNumber { get; set; }

    public string? AuthorizationStatus { get; set; }

    public int? AddressId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ApplicationNumber { get; set; }

    public int? AuthorizationFileId { get; set; }

    public int? StageId { get; set; }

    public string? PolicyNumber { get; set; }

    public bool? IsPostConstruction { get; set; }

    public int? PropertyAddressId { get; set; }

    public string? ProjectTitle { get; set; }

    public bool? IsProcessCompleted { get; set; }

    public int? AgentUserId { get; set; }

    public bool? IsAgent { get; set; }
}
