

namespace AutoBus.Domain.Models
{
    public class Bus
    {
        public int BusId { get; private set; }
        public string? NumeroPlaca { get; private set; }
        public string? Nombre { get; private set; }
        public int? CapacidadPiso1 { get; private set; }
        public int? CapacidadPiso2 { get; private set; }
        public int? CapacidadTotal { get; private set; }
        public bool? Disponible { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

        
        public List<Asiento> Asientos;

        public List<Viaje> viajes;
        


    }
}
