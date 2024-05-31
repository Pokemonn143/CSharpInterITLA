using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Infraestructure.Models
{
    [Table("ReservaDetalle")]
    public partial class ReservaDetalle
    {
        [Key]
        public int IdReservaDetalle { get; set; }
        public int? IdReserva { get; set; }
        public int? IdAsiento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCreacion { get; set; }

        [ForeignKey("IdReserva")]
        [InverseProperty("ReservaDetalles")]
        public virtual Reserva? IdReservaNavigation { get; set; }
    }
}
