
using System;

namespace Desafio_2
{

    class Program
    {
        static void Main(string[] args)
        {

            NotificacionEmail emailNotif = new NotificacionEmail("ejemplo@correo.com");
            NotificacionWhatsap whatsappNotif = new NotificacionWhatsap("+123456789");
            NotificacionSMS smsNotif = new NotificacionSMS("+1234567890");

            // Ejemplo de uso
            emailNotif.Notificar("¡Hola! Este es un correo de prueba.");
            whatsappNotif.Notificar("¡Hola! Este es un mensaje de prueba.");
            smsNotif.Notificar("¡Hola! Este es un SMS de prueba.");
        }
    }
}
