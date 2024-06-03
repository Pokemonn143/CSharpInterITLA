

using AutoBus.Domain.Entities;

namespace AutoBus.Domain.Interfaces
{
    public interface IAsiento
    {
        Task Save(Asiento departament);
        Task Save(List<Asiento> departaments);

        Task Update(Asiento departament);

        Task Update(List<Asiento> departaments);

        Task Get(int ID);

        Task<List<Asiento>> Getall();
    }
}
