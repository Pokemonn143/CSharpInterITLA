using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        Task<Viaje> Get(int ID);

        Task<List<Viaje>> Getall();

        Task<bool> Exists(Expression<Func<Viaje, bool>> filter);
    }
}
