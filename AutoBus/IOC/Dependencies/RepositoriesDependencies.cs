using AutoBus.Domain.Interfaces.Repository;
using Microsoft.Extensions.DependencyInjection;
using AutoBus.Infraestructure.Repositories;

namespace IOC.Dependencies
{
    public static class RepositoriesDependencies
    {
        public static void AddRepositoriesDependencies(this IServiceCollection services) 
        
        {

            services.AddScoped<IAsientoRepository, AsientoRepository>();
            services.AddScoped<IBusRepository, BusRepository>();
            services.AddScoped<IReservaRepository, ReservaRepository>();
            services.AddScoped<IReservaDetalleRepository, ReservaDetalleRepository>();
            services.AddScoped<IRutaRepository, RutaRepository>();
            services.AddScoped<IUsuarioRepository, UsuarioRepository>();
            services.AddScoped<IViajeRepository, ViajeRepository>();
        }
    }
}
