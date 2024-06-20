using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Core
{
    public abstract class AuditableEntity
    {
        [Column(TypeName = "datetime")]
        public DateTime? FechaCreacion { get; set; }
    }
}
