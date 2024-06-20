using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Repositories
{
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        private readonly BusDbContext _DbContext;
        public BusRepository(BusDbContext context) : base(context)
        {
            this._DbContext = context;
        }
        public List<BusSelectModel> GetBuses()
        {
            throw new NotImplementedException();
        }
    }
}
