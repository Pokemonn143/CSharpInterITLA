using AutoBus.Domain.Entities;
using AutoBus.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Extensions
{
    public static class AsientoExtensions 
    {
        public static AsientoSelectModel ConvertToModel(this Asiento asiento)
        {
            AsientoSelectModel model = new AsientoSelectModel()
            {
                AsientoId = asiento.IdAsiento,
                BusId = asiento.IdBus,
                NumeroPiso = asiento.NumeroPiso,
                NumeroAsiento = asiento.NumeroAsiento,
                FechaCreacion = asiento.FechaCreacion
            };
            return model;
        }


    }
}
