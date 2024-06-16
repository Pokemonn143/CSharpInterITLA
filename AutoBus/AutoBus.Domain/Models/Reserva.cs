

using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class ReservaBaseModel
    {
        public int ReservaId { get;  set; }
        public int? ViajeId { get;  set; }
        public int? PasajeroId { get;  set; }
        public int? AsientosReservados { get;  set; }
        public decimal? MontoTotal { get;  set; }
       
    }

    public class ReservaDeleteModel : DeleteEntityModelBase { }

    public class ReservaUpdateModel : ReservaBaseModel
    {
        public DateTime? FechaCreacion { get; set; }
    }

    public class ReservaCreateModel : ReservaBaseModel 
    {

        public DateTime? FechaCreacion { get; set; }
    }

    public class ReservaSelectModel : ReservaBaseModel
    {
        public List<ReservaSelectModel> reservaDetalles;
    }
}
