﻿using AutoBus.Domain.Entities;
using AutoBus.Domain.Interfaces;
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
    public class ReservaRepository : BaseRepository<Reserva>, IReservaRepository
    {
        private readonly BusDbContext _DbContext;
        private readonly IMapper _mapper;
        public ReservaRepository(BusDbContext context, IMapper mapper) : base(context)
        {
            this._DbContext = context;
            this._mapper = mapper;
        }
        public List<ReservaSelectModel> GetReservasByPasajero (int pasajero)
        {
            var reservas = _DbContext.Reservas
            .Where(r => r.IdPasajero == pasajero)
            .ToList();

            var ReservaModels = _mapper.Map<List<ReservaSelectModel>>(reservas);

            return ReservaModels;
        }
    }
}
