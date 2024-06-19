

using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class ReservaBaseModel
    {
        
        public int? ViajeId { get;  set; }
        public string? ViajeNombre { get; set; }
        public int? PasajeroId { get;  set; }

        public string? PasajeroNombre { get; set; }

        public int? AsientosReservados { get;  set; }
        public decimal? MontoTotal { get;  set; }
        public DateTime? FechaCreacion { get; set; }

    }

    public class ReservaDeleteModel : DeleteEntityModelBase { }

    public class ReservaUpdateModel : ReservaBaseModel
    {
        public int ReservaId { get; set; }
        
    }

    public class ReservaCreateModel : ReservaBaseModel 
    {

       
    }

    public class ReservaSelectModel : ReservaBaseModel
    {
        public int ReservaId { get; set; }
    }
}
