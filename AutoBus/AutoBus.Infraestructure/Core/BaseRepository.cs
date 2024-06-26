using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Infraestructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Core
{
    public abstract class BaseRepository<T> : IBaseRepository<T> where T : class 
    {
        private readonly BusDbContext _dbContext;
        private DbSet<T> _entities;
        protected BaseRepository(BusDbContext context)
        {
                this._dbContext = context;
            this._entities = this._dbContext.Set<T>();
        }

        public virtual async Task<bool> Exists(Expression<Func<T, bool>> filter)
        {
            return await this._entities.AnyAsync(filter);
        }

        public virtual async Task<T> Get(int ID)
        {
            return await _entities.FindAsync(ID);
        }

        public virtual async Task<List<T>> Getall(Expression<Func<T, bool>> filter)
        {
            return await _entities.Where(filter).ToListAsync();
        }

        public virtual async Task Save(T Entity)
        {
            this._entities.Add(Entity);
            await this._dbContext.SaveChangesAsync();
        }

        public virtual async Task Save(List<T> Entidades)
        {
            this._entities.AddRange(Entidades);
            await this._dbContext.SaveChangesAsync();
        }

        public virtual async Task Update(T Entity)
        {
            this._entities.Update(Entity);
            await this._dbContext.SaveChangesAsync();
        }

        public virtual async Task Update(List<T> Entidades)
        {
            this._entities.UpdateRange(Entidades);
            await this._dbContext.SaveChangesAsync();
        }

        public virtual async Task Delete (T Entity)
        {
            
            this._entities.Update(Entity);
            await this._dbContext.SaveChangesAsync();
        }
    }
    
    }

