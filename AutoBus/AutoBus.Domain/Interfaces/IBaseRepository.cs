﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces
{
    public interface IBaseRepository<T> where T : class
    {
        Task Save(T Entity);
        Task Save(IEnumerable<T> Entidades);

        Task Update(T Entity);

        Task Update(IEnumerable<T> Entity);

        Task<T> Get(int ID);

        Task<IEnumerable<T>> Getall();
    }
}
