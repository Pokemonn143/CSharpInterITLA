

using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class BusBaseModel
    {
        
        public string? NumeroPlaca { get;  set; }
        public string? Nombre { get;  set; }
        public int? CapacidadPiso1 { get;  set; }
        public int? CapacidadPiso2 { get; set; }
        public int? CapacidadTotal { get;  set; }
        public bool? Disponible { get; set; }
        public DateTime? FechaCreacion { get; set; }

    }


    public class BusDeleteModel : DeleteEntityModelBase { }

    public class BusUpdateModel : BusBaseModel 
    {
        public int BusId { get; set; }
        

    }

    public class BusCreateModel : BusBaseModel 
    
    {
       
    }

        public class BusSelectModel : BusBaseModel 
    {
        public int BusId { get; set; }
        public List<AsientoSelectModel> Asientos;

        public List<ViajeSelectModel> viajes;



    }

}

