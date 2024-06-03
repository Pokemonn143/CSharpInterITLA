using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IReservaDetalle
    {
        Task Save(ReservaDetalle departament);
        Task Save(List<ReservaDetalle> departaments);

        Task Update(ReservaDetalle departament);

        Task Update(List<ReservaDetalle> departaments);

        Task Get(int ID);

        Task<List<ReservaDetalle>> Getall();
    }
}
