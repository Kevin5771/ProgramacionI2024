using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    public class NotificacionEmail : INotificable
    {
        private string direccionCorreo;

        public NotificacionEmail(string correo)
        {
            direccionCorreo = correo;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando correo a {direccionCorreo}: {mensaje}");
        }
    }
}
