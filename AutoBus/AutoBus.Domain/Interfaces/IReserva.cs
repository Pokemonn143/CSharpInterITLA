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
        Task Save(Reserva reserva);
        Task Save(List<Reserva> reservas);

        Task Update(Reserva reserva);

        Task Update(List<Reserva> reservas);

        Task Get(int ID);

        Task<List<Reserva>> Getall();
    }
}
