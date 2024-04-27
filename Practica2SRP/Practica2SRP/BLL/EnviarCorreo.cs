using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2SRP.BLL
{
    public static class EnviarCorreo
    {
        public static void Enviarcorreo(string Mensaje)
        {
            const string Correo = "CorreoEjemplo@gmail.com";
            const string clave = "12345";
            var Datos = Mensaje;

            Send(Datos, clave, Correo)
            {

            }


        }


    }
}
