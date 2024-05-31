using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("Usuario")]
    public partial class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Nombres { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Apellidos { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Correo { get; set; }
        [StringLength(50)]
        [Unicode(false)]
        public string? Clave { get; set; }
        [StringLength(20)]
        [Unicode(false)]
        public string? TipoUsuario { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCreacion { get; set; }
    }
}
