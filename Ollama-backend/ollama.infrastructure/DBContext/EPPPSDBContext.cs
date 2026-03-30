using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using ollama.infrastructure.Models;

namespace ollama.infrastructure.DBContext;

public partial class EPPPSDBContext : DbContext
{
    public EPPPSDBContext()
    {
    }

    public EPPPSDBContext(DbContextOptions<EPPPSDBContext> options)
        : base(options)
    {
    }

    public virtual DbSet<LasbcaauthorizationCommence> LasbcaauthorizationCommences { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.0.0.4;Database=EPPPS-dev;User Id=epppsdevusr@sqlsrvr-fhti-dev.privatelink.database.windows.net;Password=n9jWkL3dEr@5;Encrypt=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<LasbcaauthorizationCommence>(entity =>
        {
            entity.HasKey(e => e.AuthorizationCommenceId).HasName("PK__LASBCAAuthorizationCommence");

            entity.ToTable("LASBCAAuthorizationCommence");

            entity.HasIndex(e => new { e.IsProcessCompleted, e.CreatedOn }, "IX_LASBCAAuthorizationCommence_IsProcessCompleted_CreatedOn").IsDescending(false, true);

            entity.Property(e => e.ApplicationNumber)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.AuthorizationStatus).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.IsProcessCompleted).HasDefaultValue(false);
            entity.Property(e => e.PermitNumber).HasMaxLength(200);
            entity.Property(e => e.PolicyNumber).HasMaxLength(500);
            entity.Property(e => e.ProjectTitle).HasMaxLength(255);
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
