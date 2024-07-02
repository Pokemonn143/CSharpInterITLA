using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;
namespace ViajeRepoTest;
public class ViajeRepositoryTests
{
    [Fact]
    public void CanAddAndRetrieveViaje()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var viaje = new Viaje
        {
            IdViaje = 1,
            IdBus = 1,
            IdRuta = 1,
            FechaSalida = DateTime.Now.Date,
            HoraSalida = new TimeSpan(8, 0, 0),
            FechaLlegada = DateTime.Now.Date,
            HoraLlegada = new TimeSpan(12, 0, 0),
            Precio = 50.00m,
            TotalAsientos = 50,
            AsientosReservados = 0,
            AsientoDisponibles = 50,
            Completo = 0,
            FechaCreacion = DateTime.Now
        };

        // Act
        dbContext.Viajes.Add(viaje);
        dbContext.SaveChanges();

        var retrievedViaje = dbContext.Viajes.Find(viaje.IdViaje);

        // Assert
        Assert.NotNull(retrievedViaje);
        Assert.Equal(viaje.IdViaje, retrievedViaje.IdViaje);
        Assert.Equal(viaje.IdBus, retrievedViaje.IdBus);
        Assert.Equal(viaje.IdRuta, retrievedViaje.IdRuta);
        Assert.Equal(viaje.FechaSalida, retrievedViaje.FechaSalida);
        Assert.Equal(viaje.HoraSalida, retrievedViaje.HoraSalida);
        Assert.Equal(viaje.FechaLlegada, retrievedViaje.FechaLlegada);
        Assert.Equal(viaje.HoraLlegada, retrievedViaje.HoraLlegada);
        Assert.Equal(viaje.Precio, retrievedViaje.Precio);
        Assert.Equal(viaje.TotalAsientos, retrievedViaje.TotalAsientos);
        Assert.Equal(viaje.AsientosReservados, retrievedViaje.AsientosReservados);
        Assert.Equal(viaje.AsientoDisponibles, retrievedViaje.AsientoDisponibles);
        Assert.Equal(viaje.Completo, retrievedViaje.Completo);
    }

    [Fact]
    public void CanUpdateViaje()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var viaje = new Viaje
        {
            IdViaje = 1,
            IdBus = 1,
            IdRuta = 1,
            FechaSalida = DateTime.Now.Date,
            HoraSalida = new TimeSpan(8, 0, 0),
            FechaLlegada = DateTime.Now.Date,
            HoraLlegada = new TimeSpan(12, 0, 0),
            Precio = 50.00m,
            TotalAsientos = 50,
            AsientosReservados = 0,
            AsientoDisponibles = 50,
            Completo = 0,
            FechaCreacion = DateTime.Now
        };

        dbContext.Viajes.Add(viaje);
        dbContext.SaveChanges();

        // Act
        viaje.Precio = 60.00m;
        dbContext.Viajes.Update(viaje);
        dbContext.SaveChanges();

        var updatedViaje = dbContext.Viajes.Find(viaje.IdViaje);

        // Assert
        Assert.NotNull(updatedViaje);
        Assert.Equal(viaje.Precio, updatedViaje.Precio);
    }

    [Fact]
    public void CanDeleteViaje()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var viaje = new Viaje
        {
            IdViaje = 1,
            IdBus = 1,
            IdRuta = 1,
            FechaSalida = DateTime.Now.Date,
            HoraSalida = new TimeSpan(8, 0, 0),
            FechaLlegada = DateTime.Now.Date,
            HoraLlegada = new TimeSpan(12, 0, 0),
            Precio = 50.00m,
            TotalAsientos = 50,
            AsientosReservados = 0,
            AsientoDisponibles = 50,
            Completo = 0,
            FechaCreacion = DateTime.Now
        };

        dbContext.Viajes.Add(viaje);
        dbContext.SaveChanges();

        // Act
        dbContext.Viajes.Remove(viaje);
        dbContext.SaveChanges();

        var deletedViaje = dbContext.Viajes.Find(viaje.IdViaje);

        // Assert
        Assert.Null(deletedViaje);
    }

    [Fact]
    public void CanRetrieveAllViajes()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var viaje1 = new Viaje
        {
            IdViaje = 1,
            IdBus = 1,
            IdRuta = 1,
            FechaSalida = DateTime.Now.Date,
            HoraSalida = new TimeSpan(8, 0, 0),
            FechaLlegada = DateTime.Now.Date,
            HoraLlegada = new TimeSpan(12, 0, 0),
            Precio = 50.00m,
            TotalAsientos = 50,
            AsientosReservados = 0,
            AsientoDisponibles = 50,
            Completo = 0,
            FechaCreacion = DateTime.Now
        };

        var viaje2 = new Viaje
        {
            IdViaje = 2,
            IdBus = 2,
            IdRuta = 2,
            FechaSalida = DateTime.Now.Date.AddDays(1),
            HoraSalida = new TimeSpan(10, 0, 0),
            FechaLlegada = DateTime.Now.Date.AddDays(1),
            HoraLlegada = new TimeSpan(14, 0, 0),
            Precio = 60.00m,
            TotalAsientos = 40,
            AsientosReservados = 10,
            AsientoDisponibles = 30,
            Completo = 0,
            FechaCreacion = DateTime.Now
        };

        dbContext.Viajes.AddRange(viaje1, viaje2);
        dbContext.SaveChanges();

        // Act
        var allViajes = dbContext.Viajes.ToList();

        // Assert
        Assert.Equal(2, allViajes.Count);
        Assert.Contains(allViajes, v => v.IdViaje == viaje1.IdViaje);
        Assert.Contains(allViajes, v => v.IdViaje == viaje2.IdViaje);
    }
}
