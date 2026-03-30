using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Lasbcacomment
{
    public int Id { get; set; }

    public int? ApplicationId { get; set; }

    public string? CreatedBy { get; set; }

    public DateOnly? CreatedDate { get; set; }

    public string? Comments { get; set; }
}
