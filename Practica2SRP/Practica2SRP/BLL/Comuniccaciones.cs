using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2SRP.BLL
{
    public  class Comuniccaciones:INotificacion
    {
        private INotificacion Inotificacion;

        public Comuniccaciones(INotificacion Notificacion)
        {
            this.Inotificacion = Notificacion;
        }

        public void EnviarCorreo(string Mensaje)
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
