using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertificationTeamLeadFieldOfficer
{
    public int Id { get; set; }

    public int? FieldOfficerId { get; set; }

    public int? TeamLeadId { get; set; }

    public int? ApplicationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public int? StatusNumber { get; set; }
}
