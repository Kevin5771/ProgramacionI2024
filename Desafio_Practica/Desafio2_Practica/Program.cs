
using System;
using System.ComponentModel.Design;

namespace Desafio2_Practica
{
    class Program
    {

        /* Crea un programa en C# que simule un sistema de gestión de empleados en una empresa. 
         * El programa debe permitir al usuario realizar las siguientes operaciones:

            Registrar un nuevo empleado.
            Actualizar la información de un empleado existente.
            Calcular el salario de un empleado.
            Mostrar la información de un empleado.
            Mostrar la lista de todos los empleados.
            Salir del programa.
            Cada empleado debe tener los siguientes datos: nombre, apellido, edad, cargo y salario. 
            El programa debe permitir al usuario seleccionar estas operaciones mediante un menú.*/
        static void Main(string[] args)
        {
            Empleado[] empleados = new Empleado[10];
            byte contadorEmpleado = 0;
            bool active = true;

            while (active == true)
            {

                Console.WriteLine("Bienvenido al sistema de gestión de Empleados ");
                Console.WriteLine("1. Registrar un nuevo empleado");
                Console.WriteLine("2. Actualizar la información de un empleado existente");
                Console.WriteLine("3. Calcular el salario de un empleado");
                Console.WriteLine("4. Mostrar la información de un empleado");
                Console.WriteLine("5. Mostrar la lista de todos los empleados");
                Console.WriteLine("6. Salir del programa");

                Console.Write("Seleccione una opción: ");
                byte op = byte.Parse(Console.ReadLine());

                switch (op)
                {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del empleado:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del empleado:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese la edad del empleado:");
                        int edad = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el DPI del empleado:");
                        int dpi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el cargo del empleado:");
                        string cargo = Console.ReadLine();
                        Console.WriteLine("Ingrese el salario del empleado:");
                        double salario = double.Parse(Console.ReadLine());

                        // Crear un nuevo empleado y agregarlo a la lista
                        Empleado nuevoEmpleado = new Empleado(nombre, apellido, edad, dpi, cargo, salario);
                        contadorEmpleado++;
                        Console.WriteLine("Empleado registrado exitosamente.");
                        break;
                    case 2:
                        Console.WriteLine("Ingrese el nombre del empleado a actualizar:");
                        string nombreEmpleadoActualizar = Console.ReadLine();
                        foreach( var empleado in empleados)
                        {
                            if (empleado !=  null )
                            {

                            }
                        }
                        break;
                }


            } 
        }
    }
}