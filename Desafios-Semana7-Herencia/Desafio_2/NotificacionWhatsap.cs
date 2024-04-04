using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_2
{
    public class NotificacionWhatsap : INotificable
    {
        public string numeroTelefono;

        public NotificacionWhatsap(string telefono)
        {
            numeroTelefono = telefono;
        }

        public void Notificar(string mensaje)
        {
            Console.WriteLine($"Enviando mensaje por WhatsApp al número {numeroTelefono}: {mensaje}");
        }
    }
}
