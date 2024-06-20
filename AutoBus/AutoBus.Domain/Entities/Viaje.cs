using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("Viaje")]
    public partial class Viaje:AuditableEntity
    {
        public Viaje()
        {
            Reservas = new HashSet<Reserva>();
        }

        [Key]
        public int IdViaje { get; set; }
        public int? IdBus { get; set; }
        public int? IdRuta { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaSalida { get; set; }
        public TimeSpan? HoraSalida { get; set; }
        [Column(TypeName = "date")]
        public DateTime? FechaLlegada { get; set; }
        public TimeSpan? HoraLlegada { get; set; }
        [Column(TypeName = "decimal(10, 2)")]
        public decimal? Precio { get; set; }
        public int? TotalAsientos { get; set; }
        public int? AsientosReservados { get; set; }
        public int? AsientoDisponibles { get; set; }
        public int Completo { get; set; }
        
       

        [ForeignKey("IdBus")]
        [InverseProperty("Viajes")]
        public virtual Bus? IdBusNavigation { get; set; }
        [ForeignKey("IdRuta")]
        [InverseProperty("Viajes")]
        public virtual Ruta? IdRutaNavigation { get; set; }
        [InverseProperty("IdViajeNavigation")]
        public virtual ICollection<Reserva> Reservas { get; set; }
    }
}
