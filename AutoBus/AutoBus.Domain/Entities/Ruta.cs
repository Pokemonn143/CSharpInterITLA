using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    public partial class Ruta
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
        public DateTime? FechaCreacion { get; set; }

        [InverseProperty("IdRutaNavigation")]
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
