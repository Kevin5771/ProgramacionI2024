using System;
using System.Collections.Generic;

namespace Desafio_3
{
    class Program
    {
        static void menuTareas()
        {
            List<string> tareas = new List<string>();
            bool activo = true;

            while (activo)
            {
                Console.WriteLine("App de Tareas");
                Console.WriteLine("1. Agregar Tarea");
                Console.WriteLine("2. Mostrar Tareas");
                Console.WriteLine("3. Eliminar Tarea");
                Console.WriteLine("4. Salir");
                Console.WriteLine("Seleccione una opción:");
                
                ///Usamos una validación de datos validos en el menu
                if (!byte.TryParse(Console.ReadLine(), out byte opcion))
                {
                    Console.WriteLine("Opción inválida. Introduzca un número válido.");
                    continue;
                }

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Describe tu tarea: ");
                        string tarea = Console.ReadLine();
                        tareas.Add(tarea);
                        Console.WriteLine("Tarea agregada exitosamente.");
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("Mostrar Tareas:");
                        if (tareas.Count == 0)
                        {
                            Console.WriteLine("No hay tareas disponibles.");
                            Console.WriteLine();
                        }
                        else
                        {
                            foreach (var t in tareas)
                            {
                                Console.WriteLine(t);
                            }
                        }
                        break;

                    case 3:
                        Console.WriteLine("Seleccione el número de la tarea a eliminar:");

                        if (!int.TryParse(Console.ReadLine(), out int indice))
                        {
                            Console.WriteLine("Número de tarea inválido.");
                            break;
                        }

                        if (indice < 1 || indice > tareas.Count)
                        {
                            Console.WriteLine("Número de tarea fuera de rango.");
                            break;
                        }

                        //removemos datos especificos de la lista
                        tareas.RemoveAt(indice - 1);
                        Console.WriteLine("Tarea eliminada exitosamente.");
                        break;

                    case 4:
                        Console.WriteLine("¡Gracias por usar la aplicación de tareas!");
                        activo = false;
                        break;

                    default:
                        Console.WriteLine("Opción inválida. Introduzca un número válido.");
                        break;
                }

            }
        }

        static void Main(string[] args)
        {
            menuTareas();
        }
    }
}
