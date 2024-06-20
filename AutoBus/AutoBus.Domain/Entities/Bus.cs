using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("Bus")]
    public partial class Bus:AuditableEntity
    {
        public Bus()
        {
            Asientos = new HashSet<Asiento>();
            Viajes = new HashSet<Viaje>();
        }

        [Key]
        public int IdBus { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? NumeroPlaca { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Nombre { get; set; }
        public int? CapacidadPiso1 { get; set; }
        public int? CapacidadPiso2 { get; set; }
        public int? CapacidadTotal { get; set; }
        public bool? Disponible { get; set; }
        
        

        [InverseProperty("IdBusNavigation")]
        public virtual ICollection<Asiento> Asientos { get; set; }
        [InverseProperty("IdBusNavigation")]
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
