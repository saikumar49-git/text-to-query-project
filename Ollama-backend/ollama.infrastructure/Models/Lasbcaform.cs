using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcaform
{
    public int FsFormId { get; set; }

    public int? FsDetailId { get; set; }

    public bool? IsSupervisingConsultant { get; set; }

    public int? FsSupervisingConsultantId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public string? FormName { get; set; }

    public int? ApplicationStageId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
