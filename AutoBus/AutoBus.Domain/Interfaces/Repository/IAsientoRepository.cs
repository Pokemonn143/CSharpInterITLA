using AutoBus.Domain.Entities;
using AutoBus.Domain.Models;


namespace AutoBus.Domain.Interfaces.Repository
{
    public interface IAsientoRepository: IBaseRepository<Asiento>
    {
        List<AsientoSelectModel> GetAsientos();

    }
}
