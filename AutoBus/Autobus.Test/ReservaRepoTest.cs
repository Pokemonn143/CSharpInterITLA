using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using Xunit;
namespace ReservaRepoTest;
public class ReservaRepositoryTests
{
    [Fact]
    public void CanAddAndRetrieveReserva()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var reserva = new Reserva
        {
            // Inicializa las propiedades de Reserva
            IdReserva = 1,
            FechaCreacion = DateTime.Now,
            // Otras propiedades según tu modelo
        };

        // Act
        dbContext.Reservas.Add(reserva);
        dbContext.SaveChanges();

        var retrievedReserva = dbContext.Reservas.Find(reserva.IdReserva);

        // Assert
        Assert.NotNull(retrievedReserva);
        Assert.Equal(reserva.IdReserva, retrievedReserva.IdReserva);
        // Otras aserciones según sea necesario
    }

    [Fact]
    public void CanUpdateReserva()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var reserva = new Reserva
        {
            IdReserva = 1,
            FechaCreacion = DateTime.Now,
            // Otras propiedades según tu modelo
        };

        dbContext.Reservas.Add(reserva);
        dbContext.SaveChanges();

        // Act
        reserva.FechaCreacion = DateTime.Now.AddDays(1); // Actualiza alguna propiedad
        dbContext.Reservas.Update(reserva);
        dbContext.SaveChanges();

        var updatedReserva = dbContext.Reservas.Find(reserva.IdReserva);

        // Assert
        Assert.NotNull(updatedReserva);
        Assert.Equal(reserva.FechaCreacion, updatedReserva.FechaCreacion);
        // Otras aserciones según sea necesario
    }

    [Fact]
    public void CanDeleteReserva()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var reserva = new Reserva
        {
            IdReserva = 1,
            FechaCreacion = DateTime.Now,
            // Otras propiedades según tu modelo
        };

        dbContext.Reservas.Add(reserva);
        dbContext.SaveChanges();

        // Act
        dbContext.Reservas.Remove(reserva);
        dbContext.SaveChanges();

        var deletedReserva = dbContext.Reservas.Find(reserva.IdReserva);

        // Assert
        Assert.Null(deletedReserva);
    }

    [Fact]
    public void CanRetrieveAllReservas()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var reserva1 = new Reserva
        {
            IdReserva = 1,
            FechaCreacion = DateTime.Now,
            // Otras propiedades según tu modelo
        };

        var reserva2 = new Reserva
        {
            IdReserva = 2,
            FechaCreacion = DateTime.Now,
            // Otras propiedades según tu modelo
        };

        dbContext.Reservas.AddRange(reserva1, reserva2);
        dbContext.SaveChanges();

        // Act
        var allReservas = dbContext.Reservas.ToList();

        // Assert
        Assert.Equal(2, allReservas.Count);
        Assert.Contains(allReservas, r => r.IdReserva == reserva1.IdReserva);
        Assert.Contains(allReservas, r => r.IdReserva == reserva2.IdReserva);
    }
}
