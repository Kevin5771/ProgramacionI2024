using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    public class NotificacionSMS : INotificable
    {
        private string numeroTelefono;

        public NotificacionSMS(string telefono)
        {
            numeroTelefono = telefono;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando SMS al número {numeroTelefono}: {mensaje}");
        }
    }
}
