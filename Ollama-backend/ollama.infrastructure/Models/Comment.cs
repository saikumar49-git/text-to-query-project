using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class Comment
{
    public int CommentId { get; set; }

    public int UserId { get; set; }

    public string Comments { get; set; } = null!;

    public int RequestServiceId { get; set; }

    public int ApplicationStageId { get; set; }

    public int ApplicationId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }
}
