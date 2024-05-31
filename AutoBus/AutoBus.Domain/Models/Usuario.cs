using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Domain.Entities
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
