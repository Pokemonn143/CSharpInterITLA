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
        Task Save(Bus Bus);
        Task Save(List<Bus> Buses);

        Task Update(Bus Bus);

        Task Update(List<Bus> Buses);

        Task Get(int ID);

        Task<List<Bus>> Getall();
    }
}
