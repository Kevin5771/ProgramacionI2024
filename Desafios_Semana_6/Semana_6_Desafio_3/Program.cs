using System;

class Program
{
    static void Main(string[] args)
    {
        double suma = 0;
        int cantidadPuntajes = 0;

        Console.WriteLine("Ingrese los puntajes del estudiante (entre 1 y 10). Escriba 'fin' para terminar:");

        while (true)
        {
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
            {
                if (cantidadPuntajes == 0)
                {
                    Console.WriteLine("No se han ingresado puntajes.");
                }
                else
                {
                    double promedio = suma / cantidadPuntajes;
                    Console.WriteLine("El puntaje promedio del estudiante es: " + promedio.ToString("0.00"));
                }
                break;
            }

            if (double.TryParse(input, out double puntaje) && puntaje >= 1 && puntaje <= 10)
            {
                suma += puntaje;
                cantidadPuntajes++;
            }
            else
            {
                Console.WriteLine("Entrada inválida. Ingrese un número válido entre 1 y 10 o 'fin' para terminar.");
            }
        }
    }
}
