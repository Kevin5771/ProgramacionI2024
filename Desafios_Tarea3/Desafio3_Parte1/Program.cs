using System;

namespace Desafio3_Parte1
{
    class Program
    {
        /* 
         * Crear un método static, que pida dos valores de entrada, los cuales debe convertir a entero y sumarlos, 
         * este método debe estar en un bloque Try-Catch-Finally y mostrar un mensaje de Error si sucede algún fallo durante 
         * la ejecución (por ejemplo si el valor introducido es un texto en lugar de un número o sí el valor introducido esta en blanco).
         */
        // out Se utiliza para devolver múltiples valores desde un método. 
        static void Pedir_Valores(out int numero1, out int numero2)
        {
            // No es necesarioiniciar la variable
            numero1 = 0;
            numero2 = 0;

            try
            {
                Console.WriteLine("Ingrese el Valor del Primer Numero:");
                string num1 = Console.ReadLine();
                numero1 = int.Parse(num1);

                Console.WriteLine("Ingrese el Valor del Segundo Numero:");
                string num2 = Console.ReadLine();
                numero2 = int.Parse(num2);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: Ha ingresado un valor no numérico.");
                Console.WriteLine("Error: " + ex.Message);
            }
            finally
            {
                if (numero1 < 0 || numero2 < 0)
                {
                    Console.WriteLine("Fin del proceso de ingreso de valores.");
                    Console.WriteLine("Numeros Negativo");

                }
            }
        }

        static void Main(string[] args)
        {
            int numero1, numero2;

            Pedir_Valores(out numero1, out numero2);

            int suma = numero1 + numero2;
            Console.WriteLine("La suma de los dos números es: " + suma);
        }
    }
}
