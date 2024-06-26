﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using AutoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("ReservaDetalle")]
    public partial class ReservaDetalle:AuditableEntity
    {
        [Key]
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }


        [JsonIgnore]
        [ForeignKey("IdReserva")]
        [InverseProperty("ReservaDetalles")]
        public virtual Reserva? IdReservaNavigation { get; set; }
    }
}
