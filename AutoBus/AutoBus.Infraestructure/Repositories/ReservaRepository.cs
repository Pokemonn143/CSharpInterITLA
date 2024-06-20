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
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        private readonly BusDbContext _DbContext;
        public ReservaRepository(BusDbContext context) : base(context)
        {
            this._DbContext = context;
        }
        public List<ReservaDetalleSelectModel> GetReservas()
        {
            throw new NotImplementedException();
        }
    }
}
