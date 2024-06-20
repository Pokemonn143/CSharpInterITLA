using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces.Repository;
using AutoBus.Domain.Models;
using AutoBus.Infraestructure.Context;
using AutoBus.Infraestructure.Core;
using AutoBus.Infraestructure.Extensions;
using AutoMapper;
using System.Linq;



namespace AutoBus.Infraestructure.Repositories
{
    public class AsientoRepository:BaseRepository<Asiento>, IAsientoRepository
    {
        private readonly BusDbContext _DbContext;
        private readonly IMapper _mapper;
        public AsientoRepository(BusDbContext context, IMapper mapper) :base(context) 
        
        { 
        
            this ._DbContext = context;
            this._mapper = mapper;
        
        }

        public List<AsientoSelectModel> GetAsientos()
        {
            var Asientos = (from As in this._DbContext.Asientos
                            join Bu in this._DbContext.buses on As.IdBus equals Bu.IdBus
                            select As).ToList();
            var AsientoModels = _mapper.Map<List<AsientoSelectModel>>(Asientos);

            return AsientoModels;
        }
    }
    }

