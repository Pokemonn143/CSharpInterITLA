using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2SRP.BLL
{
    public interface  INotificacion
    {
        void EnviarCorreo(string Mensaje);

    }
}
