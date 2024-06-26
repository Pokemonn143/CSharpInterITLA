

using AutoBus.Domain.Core;

namespace AutoBus.Domain.Models
{
    public abstract class UsuarioBaseModel
    {
        
        public string? Nombres { get;  set; }
        public string? Apellidos { get;  set; }
        public string? Correo { get;  set; }
        public string? Clave { get;  set; }
        public string? TipoUsuario { get;  set; }
        public DateTime? FechaCreacion { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class UsuarioDeleteModel : DeleteEntityModelBase { }

    public class UsuarioUpdateModel : UsuarioBaseModel
    {
        public int UsuarioId { get; set; }
    }

    public class UsuarioCreateModel : UsuarioBaseModel 
    {
       

    }

    public class UsuarioSelectModel : UsuarioBaseModel 
    {

        public int UsuarioId { get; set; }

    }
}
