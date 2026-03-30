using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class SmsliveInput
{
    public int Id { get; set; }

    public string? Smsheader { get; set; }

    public string? Smsbody { get; set; }

    public DateTime? SmssentDate { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? Route { get; set; }

    public string? SenderId { get; set; }

    public string? MessageText { get; set; }

    public string? MobileNumbers { get; set; }

    public string? BatchId { get; set; }
}
