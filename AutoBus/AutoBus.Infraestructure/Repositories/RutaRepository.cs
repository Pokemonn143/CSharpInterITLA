using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Repositories
{
    public class RutaRepository : BaseRepository<Ruta>, IRutaRepository
    {
        private readonly BusDbContext _DbContext;
        public RutaRepository(BusDbContext context) : base(context)
        {
            this._DbContext = context;
        }
        public List<RutaSelectModel> GetRutas()
        {
            throw new NotImplementedException();
        }
    }
}
