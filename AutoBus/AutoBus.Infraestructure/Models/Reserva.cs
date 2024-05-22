using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Infraestructure.Models
{
    [Table("Reserva")]
    public partial class Reserva
    {
        public Reserva()
        {
            ReservaDetalles = new HashSet<ReservaDetalle>();
        }

        [Key]
        public int IdReserva { get; set; }
        public int? IdViaje { get; set; }
        public int? IdPasajero { get; set; }
        public int? AsientosReservados { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? MontoTotal { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCreacion { get; set; }

        //[ForeignKey("IdViaje")]
        //[InverseProperty("Reservas")]
        //public virtual Viaje? IdViajeNavigation { get; set; }
        [InverseProperty("IdReservaNavigation")]
        public virtual ICollection<ReservaDetalle> ReservaDetalles { get; set; }
    }
}
