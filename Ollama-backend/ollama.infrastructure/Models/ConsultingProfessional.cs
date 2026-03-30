using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ConsultingProfessional
{
    public int ConsultingProfessionalId { get; set; }

    public int? ApplicationId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public string? Comment { get; set; }

    public bool? IsApproved { get; set; }

    public bool? IsPending { get; set; }

    public int? ApplicationStageId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? RequestServiceId { get; set; }
}
