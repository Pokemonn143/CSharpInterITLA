using AutoBus.Domain.Entities;
using AutoBus.Domain.Models;
using AutoMapper;

namespace AutoBus.Infraestructure.Extensions
{
    public class Profiles:Profile
    {
        public Profiles()
        {
            CreateMap<Asiento, AsientoSelectModel>();
            CreateMap<AsientoSelectModel, Asiento>();
            CreateMap<Bus, BusSelectModel>();
            CreateMap<BusSelectModel, Bus>();

            CreateMap<Reserva, ReservaSelectModel>();
            CreateMap<ReservaSelectModel, Reserva>();

            CreateMap<ReservaDetalle, ReservaDetalleSelectModel>();
            CreateMap<ReservaDetalleSelectModel, ReservaDetalle>();

            CreateMap<Ruta, RutaSelectModel>();
            CreateMap<RutaSelectModel, Ruta>();

            CreateMap<Usuario, UsuarioSelectModel>();
            CreateMap<UsuarioSelectModel, Usuario>();

            CreateMap<Viaje, ViajeSelectModel>();
            CreateMap<ViajeSelectModel, Viaje>();
        }
        
    }
}
