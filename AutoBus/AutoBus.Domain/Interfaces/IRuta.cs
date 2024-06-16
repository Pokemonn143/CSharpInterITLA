using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IRuta
    {
        Task Save(Ruta ruta);
        Task Save(List<Ruta> rutas);

        Task Update(Ruta rutas);

        Task Update(List<Ruta> rutas);

        Task Get(int ID);

        Task<List<Ruta>> Getall();
    }
}
