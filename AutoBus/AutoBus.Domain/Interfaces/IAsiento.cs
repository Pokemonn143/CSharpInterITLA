

using AutoBus.Domain.Entities;
using System.Linq.Expressions;

namespace AutoBus.Domain.Interfaces
{
    public interface IAsiento
    {
        Task Save(Asiento Asiento);
        Task Save(List<Asiento> Asientos);

        Task Update(Asiento Asiento);

        Task Update(List<Asiento> Asientos);

        Task<Asiento> Get(int ID);

        Task<List<Asiento>> Getall();

        Task<bool> Exists(Expression<Func<Asiento, bool>> filter);
    }
}
