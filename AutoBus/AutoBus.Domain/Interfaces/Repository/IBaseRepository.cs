﻿using AutoBus.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces.Repository
{
    public interface IBaseRepository<T> where T : class
    {
        Task Save(T Entity);
        Task Save(List<T> Entidades);

        Task Update(T Entity);

        Task Update(List<T> Entidades);

        Task<bool> Exists(Expression<Func<T, bool>> filter);

        Task<T> Get(int ID);

        Task<List<T>> Getall(Expression<Func<T, bool>> filter);

        Task Delete(T Entity);
    }
}
