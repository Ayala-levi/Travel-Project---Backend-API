﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Travel.Core;

#nullable disable

namespace Travel.Data.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Travel.Data.Entities.Participant", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<int>("TourId")
                        .HasColumnType("int")
                        .HasColumnName("TourID");

                    b.Property<DateTime?>("RegistrationDate")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasDefaultValueSql("(getdate())");

                    b.HasKey("UserId", "TourId")
                        .HasName("PK__Particip__018C020DC9ADA893");

                    b.HasIndex("TourId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Travel.Data.Entities.Tour", b =>
                {
                    b.Property<int>("TourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("TourID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TourId"));

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("Location")
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<int>("OrganizerId")
                        .HasColumnType("int")
                        .HasColumnName("OrganizerID");

                    b.Property<DateTime?>("StartDate")
                        .HasColumnType("date");

                    b.Property<string>("TourName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.HasKey("TourId")
                        .HasName("PK__Tours__604CEA1097E15B05");

                    b.HasIndex("OrganizerId");

                    b.ToTable("Tours");
                });

            modelBuilder.Entity("Travel.Data.Entities.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.HasKey("UserId")
                        .HasName("PK__Users__1788CCAC1BD66CD2");

                    b.HasIndex(new[] { "Username" }, "UQ__Users__536C85E4C0F7173F")
                        .IsUnique();

                    b.HasIndex(new[] { "Email" }, "UQ__Users__A9D105342AE15663")
                        .IsUnique();

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Travel.Data.Entities.UserDetail", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int")
                        .HasColumnName("UserID");

                    b.Property<string>("FirstName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("LastName")
                        .HasMaxLength(50)
                        .IsUnicode(false)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("PhoneNumber")
                        .HasMaxLength(20)
                        .IsUnicode(false)
                        .HasColumnType("varchar(20)");

                    b.HasKey("UserId")
                        .HasName("PK__UserDeta__1788CCACA1DC41D3");

                    b.ToTable("UserDetails");
                });

            modelBuilder.Entity("Travel.Data.Entities.Participant", b =>
                {
                    b.HasOne("Travel.Data.Entities.Tour", "Tour")
                        .WithMany("Participants")
                        .HasForeignKey("TourId")
                        .IsRequired()
                        .HasConstraintName("FK__Participa__TourI__5535A963");

                    b.HasOne("Travel.Data.Entities.User", "User")
                        .WithMany("Participants")
                        .HasForeignKey("UserId")
                        .IsRequired()
                        .HasConstraintName("FK__Participa__UserI__5441852A");

                    b.Navigation("Tour");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Travel.Data.Entities.Tour", b =>
                {
                    b.HasOne("Travel.Data.Entities.User", "Organizer")
                        .WithMany("Tours")
                        .HasForeignKey("OrganizerId")
                        .IsRequired()
                        .HasConstraintName("FK__Tours__Organizer__5070F446");

                    b.Navigation("Organizer");
                });

            modelBuilder.Entity("Travel.Data.Entities.UserDetail", b =>
                {
                    b.HasOne("Travel.Data.Entities.User", "User")
                        .WithOne("UserDetail")
                        .HasForeignKey("Travel.Data.Entities.UserDetail", "UserId")
                        .IsRequired()
                        .HasConstraintName("FK__UserDetai__UserI__4D94879B");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Travel.Data.Entities.Tour", b =>
                {
                    b.Navigation("Participants");
                });

            modelBuilder.Entity("Travel.Data.Entities.User", b =>
                {
                    b.Navigation("Participants");

                    b.Navigation("Tours");

                    b.Navigation("UserDetail");
                });
#pragma warning restore 612, 618
        }
    }
}
