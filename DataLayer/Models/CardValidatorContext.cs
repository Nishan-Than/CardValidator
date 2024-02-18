using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace DataLayer.Models;

public partial class CardValidatorContext : DbContext
{
    public CardValidatorContext()
    {
    }

    public CardValidatorContext(DbContextOptions<CardValidatorContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ValidationInfo> ValidationInfos { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CIN7-NISHANTHAN;Database=CardValidator;Integrated Security=True;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ValidationInfo>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Validati__3214EC0782C77020");

            entity.ToTable("ValidationInfo");

            entity.Property(e => e.CardType).HasMaxLength(20);
            entity.Property(e => e.StartWith).HasMaxLength(20);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
