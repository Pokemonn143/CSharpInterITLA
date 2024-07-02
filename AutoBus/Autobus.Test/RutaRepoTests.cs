using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;
namespace RutaRepoTest;
public class RutaRepositoryTests
{
    [Fact]
    public void CanAddAndRetrieveRuta()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var ruta = new Ruta
        {
            IdRuta = 1,
            Origen = "Origen 1",
            Destino = "Destino 1",
            FechaCreacion = DateTime.Now
        };

        // Act
        dbContext.Ruta.Add(ruta);
        dbContext.SaveChanges();

        var retrievedRuta = dbContext.Ruta.Find(ruta.IdRuta);

        // Assert
        Assert.NotNull(retrievedRuta);
        Assert.Equal(ruta.IdRuta, retrievedRuta.IdRuta);
        Assert.Equal(ruta.Origen, retrievedRuta.Origen);
        Assert.Equal(ruta.Destino, retrievedRuta.Destino);
    }

    [Fact]
    public void CanUpdateRuta()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var ruta = new Ruta
        {
            IdRuta = 1,
            Origen = "Origen 1",
            Destino = "Destino 1",
            FechaCreacion = DateTime.Now
        };

        dbContext.Ruta.Add(ruta);
        dbContext.SaveChanges();

        // Act
        ruta.Origen = "Origen Actualizado";
        ruta.Destino = "Destino Actualizado";
        dbContext.Ruta.Update(ruta);
        dbContext.SaveChanges();

        var updatedRuta = dbContext.Ruta.Find(ruta.IdRuta);

        // Assert
        Assert.NotNull(updatedRuta);
        Assert.Equal(ruta.Origen, updatedRuta.Origen);
        Assert.Equal(ruta.Destino, updatedRuta.Destino);
    }

    [Fact]
    public void CanDeleteRuta()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var ruta = new Ruta
        {
            IdRuta = 1,
            Origen = "Origen 1",
            Destino = "Destino 1",
            FechaCreacion = DateTime.Now
        };

        dbContext.Ruta.Add(ruta);
        dbContext.SaveChanges();

        // Act
        dbContext.Ruta.Remove(ruta);
        dbContext.SaveChanges();

        var deletedRuta = dbContext.Ruta.Find(ruta.IdRuta);

        // Assert
        Assert.Null(deletedRuta);
    }

    [Fact]
    public void CanRetrieveAllRutas()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var ruta1 = new Ruta
        {
            IdRuta = 1,
            Origen = "Origen 1",
            Destino = "Destino 1",
            FechaCreacion = DateTime.Now
        };

        var ruta2 = new Ruta
        {
            IdRuta = 2,
            Origen = "Origen 2",
            Destino = "Destino 2",
            FechaCreacion = DateTime.Now
        };

        dbContext.Ruta.AddRange(ruta1, ruta2);
        dbContext.SaveChanges();

        // Act
        var allRutas = dbContext.Ruta.ToList();

        // Assert
        Assert.Equal(2, allRutas.Count);
        Assert.Contains(allRutas, r => r.IdRuta == ruta1.IdRuta);
        Assert.Contains(allRutas, r => r.IdRuta == ruta2.IdRuta);
    }
}
