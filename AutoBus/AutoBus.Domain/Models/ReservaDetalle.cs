

namespace AutoBus.Domain.Models
{
    public class ReservaDetalle
    {
        public int ReservaDetalleId { get; private set; }
        public int? ReservaId { get; private set; }
        public int? AsientoId { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

    }
}
