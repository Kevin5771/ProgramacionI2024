
using System;

namespace Semana_6_Desafio_4
{
    class Program
    {
        /* 
         Crear un miembro variable llamado SuperficieFrontal 
        (resultado de multiplicar Alto por Largo), el cual debe ser de solo lectura.
         */
        static void Main(string[] args)
        {
            Console.WriteLine("ingrese el ancho: ");
            string var = Console.ReadLine();
            int ancho = int.Parse(var);
            Console.WriteLine("Ingrese el Alto: ");
            int alto = int.Parse(Console.ReadLine());

            Medidaas dates = new Medidaas(alto,ancho);
            dates.CalcularSuperficie();


        }
    }
}