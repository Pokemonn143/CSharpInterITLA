using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;

public class BusDbContextInMemoryTests : DbContext
{
    private readonly DbContextOptions<BusDbContext> _options;

    public BusDbContextInMemoryTests()
    {
        _options = new DbContextOptionsBuilder<BusDbContext>()
            .UseInMemoryDatabase(databaseName: "TestDatabase")
            .Options;
    }

    public virtual DbSet<Asiento> Asientos { get; set; } = null!;
    public virtual DbSet<Bus> buses { get; set; } = null!;
    public virtual DbSet<Reserva> Reservas { get; set; } = null!;
    public virtual DbSet<ReservaDetalle> ReservaDetalles { get; set; } = null!;
    public virtual DbSet<Ruta> Ruta { get; set; } = null!;
    public virtual DbSet<Usuario> Usuarios { get; set; } = null!;
    public virtual DbSet<Viaje> Viajes { get; set; } = null!;

    public static BusDbContext GetInMemoryDbContext()
    {
        var options = new DbContextOptionsBuilder<BusDbContext>()
            .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
            .Options;

        var context = new BusDbContext(options);
        return context;
    }
}
