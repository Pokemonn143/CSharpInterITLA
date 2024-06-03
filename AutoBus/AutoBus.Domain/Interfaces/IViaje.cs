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
        Task Save(Viaje departament);
        Task Save(List<Viaje> departaments);

        Task Update(Viaje departament);

        Task Update(List<Viaje> departaments);

        Task Get(int ID);

        Task<List<Viaje>> Getall();
    }
}
