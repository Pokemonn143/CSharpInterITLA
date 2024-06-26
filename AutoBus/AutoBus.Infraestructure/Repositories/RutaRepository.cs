using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using AutoBus.Infraestructure.Exceptions;
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


        public override async Task Save(Ruta entity)
        {
            ArgumentNullException.ThrowIfNull(entity, "");

            if ((await base.Exists(cd => cd.IdRuta == entity.IdRuta))) { 

                throw new RutaDataException("");
            }
            base.Save(entity);

        }


        public override async Task Delete(Ruta Entity)
        {
            ArgumentNullException.ThrowIfNull(Entity, "");
            if (!(await base.Exists(cd => cd.IdRuta == Entity.IdRuta)))
            {

                throw new RutaDataException("");
            }
            Entity.IsDeleted = true;
            base.Delete(Entity);


        }

        public List<RutaSelectModel> ObtenerRutasConOrigenYDestino()
        {
            var rutas = _DbContext.Ruta
             .Where(r => !string.IsNullOrEmpty(r.Origen) && !string.IsNullOrEmpty(r.Destino) && !r.IsDeleted)
             .ToList();

            var RutasModels = _mapper.Map<List<RutaSelectModel>>(rutas);

            return RutasModels;
        }
    }
}
