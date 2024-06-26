﻿using AutoBus.Domain.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Models
{
    public class ViajeBaseModel
    {

        
        public int? BusId { get;  set; }

        public string? BusNombre { get; set; }
        public int? RutaId { get;  set; }
        public DateTime? FechaSalida { get;  set; }
        public TimeSpan? HoraSalida { get;  set; }
        public DateTime? FechaLlegada { get;  set; }
        public TimeSpan? HoraLlegada { get;  set; }
        public decimal? Precio { get;  set; }
        public int? TotalAsientos { get;  set; }
        public int? AsientosReservados { get;  set; }
        public int? AsientosDisponibles { get;  set; }
        public int Completo { get;  set; }
        public DateTime? FechaCreacion { get; set; }
        public bool IsDeleted { get; set; }

    }


    public class ViajeDeleteModel : DeleteEntityModelBase { }

    public class ViajeUpdateModel : ViajeBaseModel
    {
        public int ViajeId { get; set; }
    }

    public class ViajeCreateModel : ViajeBaseModel 
    {
        

    }

    public class ViajeSelectModel : ViajeBaseModel
    {
        public int ViajeId { get; set; }
        

    }

}
