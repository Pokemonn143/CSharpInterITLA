using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Exceptions
{
    public class UsuarioDataException : Exception
    {

        public UsuarioDataException(string message) : base(message)
        {

        }

    }
}
