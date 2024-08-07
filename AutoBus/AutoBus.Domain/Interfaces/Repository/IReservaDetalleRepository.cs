﻿using AutoBus.Domain.Entities;
using AutoBus.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Interfaces.Repository
{
    public interface IReservaDetalleRepository : IBaseRepository<ReservaDetalle>
    {

        List<ReservaDetalleSelectModel> GetReservaDetallesByReservaId(int reservaId);

    }
}
