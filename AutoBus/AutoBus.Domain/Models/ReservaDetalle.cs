

using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class ReservaDetalleBaseModel
    {
        
        public int? ReservaId { get;  set; }

        public int? AsientoId { get;  set; }

        public int? NumeroAsiento { get; set; }

        public DateTime? FechaCreacion { get; set; }
        public bool IsDeleted { get; set; }

    }

  

    public class ReservaDetalleDeleteModel : DeleteEntityModelBase { }

    public class ReservaDetalleUpdateModel : ReservaDetalleBaseModel
    {
        public int ReservaDetalleId { get; set; }
    }

    public class ReservaDetalleCreateModel : ReservaDetalleBaseModel 
    
    {
        
    }

    public class ReservaDetalleSelectModel : ReservaDetalleBaseModel 
    {

        public int ReservaDetalleId { get; set; }

    }
}
