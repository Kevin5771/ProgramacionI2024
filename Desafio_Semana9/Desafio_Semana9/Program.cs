using System;
using System.Text.RegularExpressions;

namespace Desafio_Semana9
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!!!");

            string texto = "Este es mi Correo Electrónico: kgutierrezl2@miumg.edu.gt;  Por favor, envíeme un correo con sus comentarios.";

            // Expresión regular para encontrar direcciones de correo electrónico válidas
            string patronCorreo = @"\b[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Z|a-z]{2,}\b";

            // El objeto Regex busca el patrón de correo electrónico
            Regex busquedaCorreo = new Regex(patronCorreo);

            MatchCollection coincidencias = busquedaCorreo.Matches(texto);

            // Direcciones de correo electrónico encontradas
            Console.WriteLine("Direcciones de correo electrónico encontradas:");
            foreach (Match match in coincidencias)
            {
                Console.WriteLine(match.Value);
            }
        }
    }
}
