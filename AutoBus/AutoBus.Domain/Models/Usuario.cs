

namespace AutoBus.Domain.Models
{
    public class Usuario
    {

        public int UsuarioId { get; private set; }
        public string? Nombres { get; private set; }
        public string? Apellidos { get; private set; }
        public string? Correo { get; private set; }
        public string? Clave { get; private set; }
        public string? TipoUsuario { get; private set; }
        public DateTime? FechaCreacion { get; private set; }

    }
}
