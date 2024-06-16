

using AutoBus.Domain.Entities;

namespace AutoBus.Domain.Interfaces
{
    public interface IAsiento
    {
        Task Save(Asiento Asiento);
        Task Save(List<Asiento> Asientos);

        Task Update(Asiento Asiento);

        Task Update(List<Asiento> Asientos);

        Task Get(int ID);

        Task<List<Asiento>> Getall();
    }
}
