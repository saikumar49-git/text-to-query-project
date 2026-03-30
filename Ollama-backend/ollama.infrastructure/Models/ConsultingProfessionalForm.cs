using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class ConsultingProfessionalForm
{
    public int Id { get; set; }

    public int ApplicationId { get; set; }

    public int UserId { get; set; }

    public int FormId { get; set; }

    public int ApplicationStageId { get; set; }

    public int RequestServiceId { get; set; }

    public bool? IsApproved { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? ApprovedBy { get; set; }

    public string? FormType { get; set; }
}
