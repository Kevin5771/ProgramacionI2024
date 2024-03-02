using System;

namespace CantidadNumero
{
    class Program
    {
        static void Main(string[] args)
        {
            bool active = true;
            int[] numbers = new int[10]; //Trabajamos con un Array 
            int contador = 0;

            while (active)
            {
                Console.WriteLine("Cantidad Indefinida de Numeros");
                Console.WriteLine("0. Salir");
                Console.WriteLine("1. Ingresar un numero:");
                Console.WriteLine("Ingrese una opción: ");
                byte op = byte.Parse(Console.ReadLine());

                switch (op)
                {
                    case 0:
                        Console.WriteLine("Haz Salido, Gracias por Usar Nuestro Programa");
                        active = false;
                        break;

                    case 1:
                        Console.WriteLine("Ingrese un Dato: ");
                        string data = Console.ReadLine();
                        int number = int.Parse(data);

                        if (number == 0) 
                        {
                            active = false;
                            break;
                        }

                        numbers[contador] = number;
                        contador++;
                        break;
                }
            }

            int sum = 0;
            for (int i = 0; i < contador; i++)
            {
                sum += numbers[i];
            }

            Console.WriteLine("La Suma es: " + sum);

            int promedio = 0;

            for(int i = 0; i < contador; i++)
            {
                promedio= numbers[i]/contador;
            }

            Console.WriteLine("El promedio es: " + promedio);
        }
    }
}
