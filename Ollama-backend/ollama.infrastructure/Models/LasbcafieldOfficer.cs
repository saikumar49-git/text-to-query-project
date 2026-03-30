using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class LasbcafieldOfficer
{
    public int Id { get; set; }

    public int? RequestServiceId { get; set; }

    public int? ApplicationId { get; set; }

    public int? ApplicationStageId { get; set; }

    public int? UserId { get; set; }

    public int? AssignedBy { get; set; }

    public string? Comment { get; set; }

    public bool? IsUploaded { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
