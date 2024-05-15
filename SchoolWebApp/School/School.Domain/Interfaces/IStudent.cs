using School.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace School.Domain.Interfaces
{
    public interface IStudent
    {
        Task Save(Student departament);
        Task Save(List<Student> departaments);

        Task Update(Student departament);

        Task Update(List<Student> departaments);

        Task Get(int ID);

        Task<List<Student>> Getall();
    }
}
