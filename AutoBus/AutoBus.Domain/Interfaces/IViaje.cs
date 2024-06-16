using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IViaje
    {
        Task Save(Viaje viaje);
        Task Save(List<Viaje> viajes);

        Task Update(Viaje viaje);

        Task Update(List<Viaje> viajes);

        Task Get(int ID);

        Task<List<Viaje>> Getall();
    }
}
