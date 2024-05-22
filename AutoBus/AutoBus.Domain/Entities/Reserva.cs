

namespace AutoBus.Domain.Entities
{
    public class Reserva
    {
        
        public int ReservaId { get; private set; }
        public int? ViajeId { get; private set; }
        public int? PasajeroId { get; private set; }
        public int? AsientosReservados { get; private set; }
        public decimal? MontoTotal { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

        public List<ReservaDetalle> reservaDetalles;
    }
}
