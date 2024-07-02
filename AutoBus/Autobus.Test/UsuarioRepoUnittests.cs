using AutoBus.Domain.Entities;
using AutoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;
namespace UsuarioRepoTest;
public class UsuarioRepositoryTests
{
    [Fact]
    public void CanAddAndRetrieveUsuario()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var usuario = new Usuario
        {
            IdUsuario = 1,
            Nombres = "John",
            Apellidos = "Doe",
            Correo = "john.doe@example.com",
            Clave = "password123",
            TipoUsuario = "Admin",
            FechaCreacion = DateTime.Now
        };

        // Act
        dbContext.Usuarios.Add(usuario);
        dbContext.SaveChanges();

        var retrievedUsuario = dbContext.Usuarios.Find(usuario.IdUsuario);

        // Assert
        Assert.NotNull(retrievedUsuario);
        Assert.Equal(usuario.IdUsuario, retrievedUsuario.IdUsuario);
        Assert.Equal(usuario.Nombres, retrievedUsuario.Nombres);
        Assert.Equal(usuario.Apellidos, retrievedUsuario.Apellidos);
        Assert.Equal(usuario.Correo, retrievedUsuario.Correo);
        Assert.Equal(usuario.Clave, retrievedUsuario.Clave);
        Assert.Equal(usuario.TipoUsuario, retrievedUsuario.TipoUsuario);
    }

    [Fact]
    public void CanUpdateUsuario()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var usuario = new Usuario
        {
            IdUsuario = 1,
            Nombres = "John",
            Apellidos = "Doe",
            Correo = "john.doe@example.com",
            Clave = "password123",
            TipoUsuario = "Admin",
            FechaCreacion = DateTime.Now
        };

        dbContext.Usuarios.Add(usuario);
        dbContext.SaveChanges();

        // Act
        usuario.Nombres = "Jane";
        usuario.Apellidos = "Smith";
        usuario.Correo = "jane.smith@example.com";
        dbContext.Usuarios.Update(usuario);
        dbContext.SaveChanges();

        var updatedUsuario = dbContext.Usuarios.Find(usuario.IdUsuario);

        // Assert
        Assert.NotNull(updatedUsuario);
        Assert.Equal(usuario.Nombres, updatedUsuario.Nombres);
        Assert.Equal(usuario.Apellidos, updatedUsuario.Apellidos);
        Assert.Equal(usuario.Correo, updatedUsuario.Correo);
    }

    [Fact]
    public void CanDeleteUsuario()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var usuario = new Usuario
        {
            IdUsuario = 1,
            Nombres = "John",
            Apellidos = "Doe",
            Correo = "john.doe@example.com",
            Clave = "password123",
            TipoUsuario = "Admin",
            FechaCreacion = DateTime.Now
        };

        dbContext.Usuarios.Add(usuario);
        dbContext.SaveChanges();

        // Act
        dbContext.Usuarios.Remove(usuario);
        dbContext.SaveChanges();

        var deletedUsuario = dbContext.Usuarios.Find(usuario.IdUsuario);

        // Assert
        Assert.Null(deletedUsuario);
    }

    [Fact]
    public void CanRetrieveAllUsuarios()
    {
        // Arrange
        var dbContext = BusDbContextInMemoryTests.GetInMemoryDbContext();

        var usuario1 = new Usuario
        {
            IdUsuario = 1,
            Nombres = "John",
            Apellidos = "Doe",
            Correo = "john.doe@example.com",
            Clave = "password123",
            TipoUsuario = "Admin",
            FechaCreacion = DateTime.Now
        };

        var usuario2 = new Usuario
        {
            IdUsuario = 2,
            Nombres = "Jane",
            Apellidos = "Smith",
            Correo = "jane.smith@example.com",
            Clave = "password456",
            TipoUsuario = "User",
            FechaCreacion = DateTime.Now
        };

        dbContext.Usuarios.AddRange(usuario1, usuario2);
        dbContext.SaveChanges();

        // Act
        var allUsuarios = dbContext.Usuarios.ToList();

        // Assert
        Assert.Equal(2, allUsuarios.Count);
        Assert.Contains(allUsuarios, u => u.IdUsuario == usuario1.IdUsuario);
        Assert.Contains(allUsuarios, u => u.IdUsuario == usuario2.IdUsuario);
    }
}
