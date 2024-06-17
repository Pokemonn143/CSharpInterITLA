using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IReservaDetalle
    {
        Task Save(ReservaDetalle reservadetalle);
        Task Save(List<ReservaDetalle> reservasdetalles);

        Task Update(ReservaDetalle reservadetalle);

        Task Update(List<ReservaDetalle> reservasdetalles);

        Task Get(int ID);

        Task<List<ReservaDetalle>> Getall();

        Task<bool> Exists(Expression<Func<ReservaDetalle, bool>> filter);
    }
}
