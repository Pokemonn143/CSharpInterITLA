using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Models
{
    public class Viaje
    {

        public int ViajeId { get; private set; }
        public int? BusId { get; private set; }
        public int? RutaId { get; private set; }
        public DateTime? FechaSalida { get; private set; }
        public TimeSpan? HoraSalida { get; private set; }
        public DateTime? FechaLlegada { get; private set; }
        public TimeSpan? HoraLlegada { get; private set; }
        public decimal? Precio { get; private set; }
        public int? TotalAsientos { get; private set; }
        public int? AsientosReservados { get; private set; }
        public int? AsientosDisponibles { get; private set; }
        public int Completo { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

        private List<Reserva> reservas;
        

    }
}
