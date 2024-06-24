using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using AutoBus.Infraestructure.Exceptions;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Repositories
{
    public class ReservaDetalleRepository : BaseRepository<ReservaDetalle>, IReservaDetalleRepository
    {
        private readonly BusDbContext _DbContext;
        private readonly IMapper _mapper;
        public ReservaDetalleRepository(BusDbContext context, IMapper mapper) : base(context)
        {
            this._DbContext = context;
            this._mapper = mapper;
        }


        public override async Task Save(ReservaDetalle entity)
        {
            ArgumentNullException.ThrowIfNull(entity, "");

            if ((await base.Exists(cd => cd.IdReservaDetalle == entity.IdReservaDetalle))) { 

                throw new ReservaDetalleDataException("");
            }
            base.Save(entity);

        }



        public List<ReservaDetalleSelectModel> GetReservaDetallesByReservaId(int reservaId)
        {
            var reservaDetalles = _DbContext.ReservaDetalles
            .Where(rd => rd.IdReserva == reservaId)
            .ToList();

            var ReservaDetallesModels = _mapper.Map<List<ReservaDetalleSelectModel>>(reservaDetalles);

            return ReservaDetallesModels;
        }
    }
}
