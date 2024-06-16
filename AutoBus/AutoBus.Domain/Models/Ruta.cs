using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class RutaBaseModel
    {
        public int RutaId { get;  set; }
        public string? Origen { get;  set; }
        public string? Destino { get;  set; }
        
    }

    public class RutaDeleteModel : DeleteEntityModelBase { }

    public class RutaUpdateModel : RutaBaseModel
    {
        public DateTime? FechaCreacion { get; set; }
    }

    public class RutaCreateModel : RutaBaseModel { }

    public class RutaSelectModel : RutaBaseModel
    {
        public List<ViajeSelectModel> viajes;
    }

}
