using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class StageCertificationApplication
{
    public int StageCertificationApplicationId { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string ApplicationNumber { get; set; } = null!;

    public int AgencyId { get; set; }

    public int RequestServiceId { get; set; }

    public virtual Agency Agency { get; set; } = null!;

    public virtual RequestService RequestService { get; set; } = null!;

    public virtual ICollection<StageCertificationApplicationDetail> StageCertificationApplicationDetails { get; set; } = new List<StageCertificationApplicationDetail>();
}
