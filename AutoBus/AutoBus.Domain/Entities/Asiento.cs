

namespace AutoBus.Domain.Entities
{
    public class Asiento
    {
        public int AsientoId { get; private set; }
        public int? BusId { get; private set; }
        public int? NumeroPiso { get; private set; }
        public int? NumeroAsiento { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

        public Asiento()
        {

        }
    }
}
