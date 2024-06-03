using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IReserva
    {
        Task Save(Reserva departament);
        Task Save(List<Reserva> departaments);

        Task Update(Reserva departament);

        Task Update(List<Reserva> departaments);

        Task Get(int ID);

        Task<List<Reserva>> Getall();
    }
}
