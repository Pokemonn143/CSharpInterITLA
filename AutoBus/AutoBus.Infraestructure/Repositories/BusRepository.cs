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
    public class BusRepository : BaseRepository<Bus>, IBusRepository
    {
        private readonly BusDbContext _DbContext;
        private readonly IMapper _mapper;
        public BusRepository(BusDbContext context, IMapper mapper) : base(context)
        {
            this._DbContext = context;
            this._mapper = mapper;
        }

        public override async Task Save(Bus entity)
        {
            ArgumentNullException.ThrowIfNull(entity, "");

            if ((await base.Exists(cd => cd.IdBus == entity.IdBus)))
            { 
                throw new AsientoDataException("");
            }
            base.Save(entity);

        }


        public List<BusSelectModel> GetBuses()
        {
            var availableBuses = _DbContext.buses
           .Where(b => b.Disponible == true)
           .ToList();

            var BusModels = _mapper.Map<List<BusSelectModel>>(availableBuses);

            return BusModels;
        }
    }
}
