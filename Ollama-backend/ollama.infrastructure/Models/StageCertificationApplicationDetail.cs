using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertificationApplicationDetail
{
    public int ApplicationDetailsId { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? SupervisingConsultantComments { get; set; }

    public string? Diqccomments { get; set; }

    public string? Tlcomments { get; set; }

    public string? Focomments { get; set; }

    public int? StageCertificationApplicationStatusId { get; set; }

    public DateTime? ScheduledDate1 { get; set; }

    public DateTime? ScheduledDate2 { get; set; }

    public DateTime? ScheduledDate3 { get; set; }

    public int StageCertificationApplicationId { get; set; }

    public int? TeamId { get; set; }

    public virtual StageCertificationApplication StageCertificationApplication { get; set; } = null!;
}
