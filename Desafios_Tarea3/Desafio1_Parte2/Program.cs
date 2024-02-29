
using System;

namespace Desafio1_Parte2
{
    class Program
    {

        /*
         Crea un sistema de inicio de sesión de usuario, donde el usuario puede primero registrarse y luego iniciar sesión. 
           El programa debe verificar si el usuario ha ingresado el nombre de usuario y la contraseña correctos al iniciar sesión 
            (por lo tanto, los mismos que utilizó al registrarse).

            Utiliza declaraciones If, ingresos del usuario y métodos para resolver el desafío.

         */
        static void Main(string[] args)
        {
            bool active = true;
            bool user = true;
            byte opcion;
            string name = "", contra = "";


           while (active == true)
            {
                Console.WriteLine("Bienvenido a Nuestro Menú:");
                Console.WriteLine("1. Registrarse");
                Console.WriteLine("2. Inicio de Sesión");
                Console.WriteLine("3. Salir");
                Console.WriteLine("Seleccione una opción: ");
                string op = Console.ReadLine();
                opcion = byte.Parse(op);

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Ingresa Tu Login");
                        Console.WriteLine("Ingresa Tu User: ");
                        name = Console.ReadLine();
                        Console.WriteLine("---------------");
                        Console.WriteLine("Ingresa Tu Contraseña:");
                        contra = Console.ReadLine();
                        Console.WriteLine("Login Exitoso");
                        break;
                    case 2:
                        Console.WriteLine("Ingresa Tu User:");
                        string name1 = Console.ReadLine();
                        Console.WriteLine("---------------");
                        Console.WriteLine("Ingresa Tu Contraseña:");
                        string contra1 = Console.ReadLine();

                        if (name == name1 && contra == contra1)
                        {
                            Console.WriteLine("Inicio Exitoso");
                        } else
                        {
                            Console.WriteLine("Error!!!");
                        }
                        break;
                    case 3:
                        active = false;
                        Console.WriteLine("Haz Salido del Login :)");
                        break;
                    default:
                        Console.WriteLine("Opción no válida.");
                        break;
                }

            }

        }
    }
}