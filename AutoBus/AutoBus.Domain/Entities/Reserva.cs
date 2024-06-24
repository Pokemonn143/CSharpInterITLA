using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using AutoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("Reserva")]
    public partial class Reserva:AuditableEntity
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


        [JsonIgnore]
        [ForeignKey("IdViaje")]
        [InverseProperty("Reservas")]
        public virtual Viaje? IdViajeNavigation { get; set; }
        [JsonIgnore]
        [InverseProperty("IdReservaNavigation")]
        public virtual ICollection<ReservaDetalle> ReservaDetalles { get; set; }
    }
}
