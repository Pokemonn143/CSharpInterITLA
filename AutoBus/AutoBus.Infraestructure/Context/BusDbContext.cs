using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AutoBus.Infraestructure.Models;

namespace AutoBus.Infraestructure.Context
{
    public partial class BusDbContext : DbContext
    {
        public BusDbContext()
        {
        }

        public BusDbContext(DbContextOptions<BusDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Asiento> Asientos { get; set; } = null!;
        public virtual DbSet<Bus> buses { get; set; } = null!;
        public virtual DbSet<Reserva> Reservas { get; set; } = null!;
        public virtual DbSet<ReservaDetalle> ReservaDetalles { get; set; } = null!;
        public virtual DbSet<Ruta> Ruta { get; set; } = null!;
        public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
        public virtual DbSet<Viaje> Viajes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=GERALDS-YOGA-7I\\SQLEXPRESS;Initial Catalog=DBBoletoBus;Integrated Security=True;Trust Server Certificate=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Asiento>(entity =>
            {
                entity.HasKey(e => e.IdAsiento)
                    .HasName("PK__Asiento__F5678721C8DE27BF");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdBusNavigation)
                    .WithMany(p => p.Asientos)
                    .HasForeignKey(d => d.IdBus)
                    .HasConstraintName("FK__Asiento__IdBus__276EDEB3");
            });

            modelBuilder.Entity<Bus>(entity =>
            {
                entity.HasKey(e => e.IdBus)
                    .HasName("PK__Bus__0EE90C0572C9C2FC");

                entity.Property(e => e.CapacidadTotal).HasComputedColumnSql("([CapacidadPiso1]+[CapacidadPiso2])", false);

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Reserva>(entity =>
            {
                entity.HasKey(e => e.IdReserva)
                    .HasName("PK__Reserva__0E49C69DB5937438");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdViajeNavigation)
                    .WithMany(p => p.Reservas)
                    .HasForeignKey(d => d.IdViaje)
                    .HasConstraintName("FK__Reserva__IdViaje__32E0915F");
            });

            modelBuilder.Entity<ReservaDetalle>(entity =>
            {
                entity.HasKey(e => e.IdReservaDetalle)
                    .HasName("PK__ReservaD__73F1E9423FA0E422");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdReservaNavigation)
                    .WithMany(p => p.ReservaDetalles)
                    .HasForeignKey(d => d.IdReserva)
                    .HasConstraintName("FK__ReservaDe__IdRes__36B12243");
            });

            modelBuilder.Entity<Ruta>(entity =>
            {
                entity.HasKey(e => e.IdRuta)
                    .HasName("PK__Ruta__887538FEF07771BB");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.IdUsuario)
                    .HasName("PK__Usuario__5B65BF97FD2B5BEF");

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<Viaje>(entity =>
            {
                entity.HasKey(e => e.IdViaje)
                    .HasName("PK__Viaje__580AB6B972D0693B");

                entity.Property(e => e.AsientoDisponibles).HasComputedColumnSql("([TotalAsientos]-[AsientosReservados])", false);

                entity.Property(e => e.Completo).HasComputedColumnSql("(case when ([TotalAsientos]-[AsientosReservados])<(1) then (1) else (0) end)", false);

                entity.Property(e => e.FechaCreacion).HasDefaultValueSql("(getdate())");

                entity.HasOne(d => d.IdBusNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdBus)
                    .HasConstraintName("FK__Viaje__IdBus__2E1BDC42");

                entity.HasOne(d => d.IdRutaNavigation)
                    .WithMany(p => p.Viajes)
                    .HasForeignKey(d => d.IdRuta)
                    .HasConstraintName("FK__Viaje__IdRuta__2F10007B");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
