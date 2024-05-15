using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Interfaces
{
    public interface IDeparment
    {
        Task  Save(Department departament);
        Task Save(List<Department> departaments);

        Task Update(Department departament);

        Task Update(List<Department> departaments);

        Task Get(int ID);

        Task<List<Department>> Getall();
    }
}
