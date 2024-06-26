using AutoBus.Domain.Entities;
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
    public class ViajeRepository : BaseRepository<Viaje>, IViajeRepository
    {
        private readonly BusDbContext _DbContext;
        private readonly IMapper _mapper;
        public ViajeRepository(BusDbContext context, IMapper mapper) : base(context)
        {
            this._DbContext = context;
            this._mapper = mapper;

        }


        public override async Task Save(Viaje entity)
        {
            ArgumentNullException.ThrowIfNull(entity, "");

            if ((await base.Exists(cd => cd.IdViaje == entity.IdViaje))) { 

                throw new ViajeDataException("");
            }

            base.Save(entity);

        }


        public override async Task Delete(Viaje Entity)
        {
            ArgumentNullException.ThrowIfNull(Entity, "");
            if (!(await base.Exists(cd => cd.IdViaje == Entity.IdViaje)))
            {

                throw new ViajeDataException("");
            }
            Entity.IsDeleted = true;
            base.Delete(Entity);


        }


        public List<ViajeSelectModel> ObtenerViajesDisponibles()
        {
            var viajes = _DbContext.Viajes
            .Where(v => v.FechaSalida != null && v.FechaLlegada != null && v.AsientoDisponibles > 0 && !v.IsDeleted)
            .ToList();

            var ViajeModels = _mapper.Map<List<ViajeSelectModel>>(viajes);

            return ViajeModels;
        }
    }
}
