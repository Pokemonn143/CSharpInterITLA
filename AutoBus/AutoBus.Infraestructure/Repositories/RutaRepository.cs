using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using AutoMapper;
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
        private readonly IMapper _mapper;
        public RutaRepository(BusDbContext context, IMapper mapper) : base(context)
        {
            this._DbContext = context;
            this._mapper = mapper;
        }
        public List<RutaSelectModel> ObtenerRutasConOrigenYDestino()
        {
            var rutas = _DbContext.Ruta
             .Where(r => !string.IsNullOrEmpty(r.Origen) && !string.IsNullOrEmpty(r.Destino))
             .ToList();

            var RutasModels = _mapper.Map<List<RutaSelectModel>>(rutas);

            return RutasModels;
        }
    }
}
