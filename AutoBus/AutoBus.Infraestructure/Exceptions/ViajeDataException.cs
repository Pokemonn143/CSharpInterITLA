using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoBus.Infraestructure.Exceptions
{
    public class ViajeDataException : Exception
    {

        public ViajeDataException(string message) : base(message)
        {

        }

    }
}
