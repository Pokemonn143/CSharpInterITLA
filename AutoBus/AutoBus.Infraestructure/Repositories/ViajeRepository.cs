using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
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
        public List<ViajeSelectModel> ObtenerViajesDisponibles()
        {
            var viajes = _DbContext.Viajes
            .Where(v => v.FechaSalida != null && v.FechaLlegada != null && v.AsientoDisponibles > 0)
            .ToList();

            var ViajeModels = _mapper.Map<List<ViajeSelectModel>>(viajes);

            return ViajeModels;
        }
    }
}
