

namespace AutoBus.Domain.Interfaces
{
    public interface IAsiento
    {
        Task Save(Department departament);
        Task Save(List<Department> departaments);

        Task Update(Department departament);

        Task Update(List<Department> departaments);

        Task Get(int ID);

        Task<List<Department>> Getall();
    }
}
