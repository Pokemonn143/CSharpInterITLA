using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Entities
{
    public class Ruta
    {
        public int RutaId { get; private set; }
        public string? Origen { get; private set; }
        public string? Destino { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

        public List<Viaje> viajes;

    }
}
