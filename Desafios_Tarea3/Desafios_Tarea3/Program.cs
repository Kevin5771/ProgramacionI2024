using System;

namespace Desafios_Tarea3
{

    // Desafio 1
    class Program
    {

        public static double PedirIngreso(string ordinal)
        {
            Console.Write($"Ingrese el ingreso del {ordinal} mes: ");
            return Convert.ToDouble(Console.ReadLine());
        }

        static void Main(string[] args)
        {
            /*  
            Crear un método static, que pida los ingresos de los últimos 3 meses, así como el nombre del usuario e imprima en pantalla 
            la suma de todos los ingresos y un promedio con un mensaje similiar a "Hola <usuario> en total ganaste suma y promediaste
            promedio ".  */

            Console.WriteLine("Ingrese su Nombre: ");
            string name = Console.ReadLine();

            Console.WriteLine("Ingrese los ingresos de los ultimos 3 meses");

            double ingresoMes1 = PedirIngreso("primer");
            double ingresoMes2 = PedirIngreso("segundo");
            double ingresoMes3 = PedirIngreso("tercer");

            double sumaIngresos = ingresoMes1 + ingresoMes2 + ingresoMes3;
            double promedioIngresos = sumaIngresos / 3;


            Console.WriteLine("Datos Generales");
            Console.WriteLine($"Hola {name}, Su Total de Ingresos es: {sumaIngresos}");
            Console.WriteLine($"El Promedio de ingresos es: {promedioIngresos}");


        }
    }
}
