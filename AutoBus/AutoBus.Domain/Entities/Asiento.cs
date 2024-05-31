using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("Asiento")]
    public partial class Asiento
    {
        [Key]
        public int IdAsiento { get; set; }
        public int? IdBus { get; set; }
        public int? NumeroPiso { get; set; }
        public int? NumeroAsiento { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? FechaCreacion { get; set; }

        [ForeignKey("IdBus")]
        [InverseProperty("Asientos")]
        public virtual Bus? IdBusNavigation { get; set; }
    }
}
