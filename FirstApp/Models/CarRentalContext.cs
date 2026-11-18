using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace FirstApp.Models;

public partial class CarRentalContext : DbContext
{
    public CarRentalContext()
    {
    }

    public CarRentalContext(DbContextOptions<CarRentalContext> options)
        : base(options)
    {
    }

    public virtual DbSet<CarRental> CarRentals { get; set; }

    public virtual DbSet<Role> Roles { get; set; }

    public virtual DbSet<TypeOfCar> TypeOfCars { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserRole> UserRoles { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=localhost;Database=CarRental;User Id=sa;Password=dev;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<CarRental>(entity =>
        {
            entity.ToTable("CarRental");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Cost).HasColumnType("decimal(18, 0)");
            entity.Property(e => e.Customer).HasMaxLength(100);
            entity.Property(e => e.DateRented).HasColumnType("datetime");
            entity.Property(e => e.DateReturned).HasColumnType("datetime");

            entity.HasOne(d => d.TypeOfCar).WithMany(p => p.CarRentals)
                .HasForeignKey(d => d.TypeOfCarId)
                .HasConstraintName("FK_CarRental_TypeOfCar");
        });

        modelBuilder.Entity<Role>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("name");
            entity.Property(e => e.ShortName)
                .HasMaxLength(50)
                .HasColumnName("shortName");
        });

        modelBuilder.Entity<TypeOfCar>(entity =>
        {
            entity.ToTable("TypeOfCar");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LicensePlateNumber).HasMaxLength(50);
            entity.Property(e => e.Make).HasMaxLength(50);
            entity.Property(e => e.Model).HasMaxLength(50);
            entity.Property(e => e.Vin)
                .HasMaxLength(50)
                .HasColumnName("VIN");
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IsActive).HasColumnName("isActive");
            entity.Property(e => e.Password)
                .HasMaxLength(100)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<UserRole>(entity =>
        {
            entity.ToTable("UserRole");

            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.RoleId).HasColumnName("roleId");
            entity.Property(e => e.UserId).HasColumnName("userId");

            entity.HasOne(d => d.Role).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.RoleId)
                .HasConstraintName("FK_UserRole_Roles");

            entity.HasOne(d => d.User).WithMany(p => p.UserRoles)
                .HasForeignKey(d => d.UserId)
                .HasConstraintName("FK_UserRole_Users");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
