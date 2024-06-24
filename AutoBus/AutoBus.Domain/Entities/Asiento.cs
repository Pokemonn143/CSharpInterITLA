using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;
using AutoBus.Domain.Core;
using Microsoft.EntityFrameworkCore;

namespace AutoBus.Domain.Entities
{
    [Table("Asiento")]
    public partial class Asiento:AuditableEntity
    {
        [Key]
        public int IdAsiento { get; set; }
        public int? IdBus { get; set; }
        public int? NumeroPiso { get; set; }
        public int? NumeroAsiento { get; set; }


        [JsonIgnore]
        [ForeignKey("IdBus")]
        [InverseProperty("Asientos")]
        public virtual Bus? IdBusNavigation { get; set; }
    }
}
