using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Core
{
    public abstract class AuditableEntity
    {
        public DateTime? FechaCreacion { get; set; }
    }
}
