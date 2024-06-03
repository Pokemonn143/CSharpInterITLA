using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        [Column(TypeName = "datetime")]
        

        [ForeignKey("IdReserva")]
        [InverseProperty("ReservaDetalles")]
        public virtual Reserva? IdReservaNavigation { get; set; }
    }
}
