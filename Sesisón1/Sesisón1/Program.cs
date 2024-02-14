
//Sirve para agregar distintas classes C#

//Importamos la biblioteca de clases 
using MiBiblioteca;

namespace Sesión1
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Declaración de Variables
            //Cada Lina de código en C# lleva ;
            int edadNumero = 0;

            MiPrimeraClase miPrimerObjeto = new MiPrimeraClase();
            decimal suma = miPrimerObjeto.Sumar(10, 20);
            Console.WriteLine("El resultado de la Suma es {0}", suma);

            /// Para compilar usamos dotnet build 
            //Console.ReadLine();

            Console.WriteLine("Ingrese su edad: ");
            string edad = Console.ReadLine();
            edadNumero = int.Parse(edad);


            if (edadNumero < 18)
            {
                Console.WriteLine("Usted es menor de Edad");

            } else
            {
                Console.WriteLine("Usted es Una Persona Mayor de edad");
            }


            Console.ReadLine();
        }


        }
            
    
}
  


