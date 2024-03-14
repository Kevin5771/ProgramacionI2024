
using System;

namespace Semana_6_Desafio_5 { 

class Program {
        /*
         Explique cuales son los pasos a seguir para crear un programa con la capacidad de obtener el total de Volumen 
        de múltiples Cajas, así como el volumen promedio (NOTA: debe aplicar tanto teoría de objetos como Loops).
         */
        static void Main(string[] args)
    {
        List<Caja> cajas = new List<Caja>();


        while (true)
        {
            Console.WriteLine("Ingrese las dimensiones de la caja (alto, ancho, profundidad) o escriba 'fin' para terminar:");
            string input = Console.ReadLine();

            if (input.ToLower() == "fin")
                break;

            string[] dimensiones = input.Split(',');
            if (dimensiones.Length != 3)
            {
                Console.WriteLine("Formato incorrecto. Por favor ingrese tres dimensiones separadas por comas.");
                continue;
            }
            //Asiganación de datos al Contructor
            if (double.TryParse(dimensiones[0], out double alto) &&
                double.TryParse(dimensiones[1], out double ancho) &&
                double.TryParse(dimensiones[2], out double profundidad))
            {
                cajas.Add(new Caja(alto, ancho, profundidad));
            }
            else
            {
                Console.WriteLine("Formato incorrecto. Por favor ingrese números válidos para las dimensiones.");
            }
        }


        double volumenTotal = 0;
        foreach (Caja caja in cajas)
        {
            volumenTotal += caja.CalcularVolumen();
        }

        // Mostrar resultados
        Console.WriteLine("El volumen total de las cajas es: " + volumenTotal);
    }
    }
}
