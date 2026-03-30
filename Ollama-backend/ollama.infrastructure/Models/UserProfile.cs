using System;
using System.Collections.Generic;

namespace ollama.infrastructure.Models;

public partial class UserProfile
{
    public int UserProfileId { get; set; }

    public int? UserId { get; set; }

    public string? SignatureFilePath { get; set; }

    public string? SignatureFileName { get; set; }

    public string? StampFilePath { get; set; }

    public string? StampFileName { get; set; }

    public string? SealFilePath { get; set; }

    public string? SealFileName { get; set; }

    public bool IsActive { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public virtual User? User { get; set; }
}
