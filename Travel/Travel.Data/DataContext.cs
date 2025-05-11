using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Travel.Data.Entities;

namespace Travel.Core;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Participant> Participants { get; set; }

    public virtual DbSet<Tour> Tours { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserDetail> UserDetails { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server=???;Database=???;" +
            "Integrated Security=True;TrustServerCertificate=True");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Participant>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.TourId }).HasName("PK__Particip__018C020DC9ADA893");

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.TourId).HasColumnName("TourID");
            entity.Property(e => e.RegistrationDate).HasDefaultValueSql("(getdate())");

            entity.HasOne(d => d.Tour).WithMany(p => p.Participants)
                .HasForeignKey(d => d.TourId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__TourI__5535A963");

            entity.HasOne(d => d.User).WithMany(p => p.Participants)
                .HasForeignKey(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Participa__UserI__5441852A");
        });

        modelBuilder.Entity<Tour>(entity =>
        {
            entity.HasKey(e => e.TourId).HasName("PK__Tours__604CEA1097E15B05");

            entity.Property(e => e.TourId).HasColumnName("TourID");
            entity.Property(e => e.Description).HasColumnType("text");
            entity.Property(e => e.EndDate).HasColumnType("date");
            entity.Property(e => e.Location)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.OrganizerId).HasColumnName("OrganizerID");
            entity.Property(e => e.StartDate).HasColumnType("date");
            entity.Property(e => e.TourName)
                .HasMaxLength(100)
                .IsUnicode(false);

            entity.HasOne(d => d.Organizer).WithMany(p => p.Tours)
                .HasForeignKey(d => d.OrganizerId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__Tours__Organizer__5070F446");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__Users__1788CCAC1BD66CD2");

            entity.HasIndex(e => e.Username, "UQ__Users__536C85E4C0F7173F").IsUnique();

            entity.HasIndex(e => e.Email, "UQ__Users__A9D105342AE15663").IsUnique();

            entity.Property(e => e.UserId).HasColumnName("UserID");
            entity.Property(e => e.Email)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserDetail>(entity =>
        {
            entity.HasKey(e => e.UserId).HasName("PK__UserDeta__1788CCACA1DC41D3");

            entity.Property(e => e.UserId)
                .ValueGeneratedNever()
                .HasColumnName("UserID");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithOne(p => p.UserDetail)
                .HasForeignKey<UserDetail>(d => d.UserId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK__UserDetai__UserI__4D94879B");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
