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
        Task Save(Ruta departament);
        Task Save(List<Ruta> departaments);

        Task Update(Ruta departament);

        Task Update(List<Ruta> departaments);

        Task Get(int ID);

        Task<List<Ruta>> Getall();
    }
}
