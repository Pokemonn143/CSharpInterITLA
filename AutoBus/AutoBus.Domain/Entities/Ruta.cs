using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using AutoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    public partial class Ruta:AuditableEntity
    {
        public Ruta()
        {
            Viajes = new HashSet<Viaje>();
        }

        [Key]
        public int IdRuta { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Origen { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Destino { get; set; }
        [Column(TypeName = "datetime")]
       

        [InverseProperty("IdRutaNavigation")]
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
