

using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class AsientoBaseModel
    {
        public int AsientoId { get;  set; }
        public int? BusId { get;  set; }
        public int? NumeroPiso { get;  set; }
        public int? NumeroAsiento { get;  set; }
    }

    public class AsientoDeleteModel : DeleteEntityModelBase { }

    public class AsientoUpdateModel:AsientoBaseModel 
    {
        public DateTime? FechaCreacion { get; set; }
    }

    public class AsientoCreateModel:AsientoBaseModel 
    {

        public DateTime? FechaCreacion { get; set; }

    }

    public class AsientoSelectModel:AsientoBaseModel 
    {
        
    }


}
