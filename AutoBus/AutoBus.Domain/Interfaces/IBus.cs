using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IBus
    {
        Task Save(Bus departament);
        Task Save(List<Bus> departaments);

        Task Update(Bus departament);

        Task Update(List<Bus> departaments);

        Task Get(int ID);

        Task<List<Bus>> Getall();
    }
}
