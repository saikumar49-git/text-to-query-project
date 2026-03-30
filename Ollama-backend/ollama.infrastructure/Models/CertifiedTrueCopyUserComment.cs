using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class CertifiedTrueCopyUserComment
{
    public int CtcuserCommentId { get; set; }

    public int? CtcapplicationId { get; set; }

    public int? CtcapplicationDetailId { get; set; }

    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public string? Comment { get; set; }

    public string? Decision { get; set; }

    public int? AssignedOfficerUid { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }
}
