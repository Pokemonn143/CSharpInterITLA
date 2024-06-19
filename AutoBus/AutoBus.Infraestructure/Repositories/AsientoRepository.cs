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
    public class AsientoRepository:BaseRepository<Asiento>, IAsientoRepository
    {
        private readonly BusDbContext _DbContext;
        public AsientoRepository(BusDbContext context):base(context) 
        
        { 
        
            this ._DbContext = context;
        
        }

        public List<AsientoSelectModel> GetAsientos()
        {
            throw new NotImplementedException();
        }
    }
    }

