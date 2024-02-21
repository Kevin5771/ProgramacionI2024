
using System;

namespace Creacion_Clases
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno alumno1 = new Alumno(1,"Kevin", "Gutierrez", new(2005, 1, 8), "55212866", "Villas de Santiago", "0907-23-1166",
                                        new (2022,11,26), "ingeniería en Sistemas");

            //Datos alumnoo 
            Console.WriteLine("\nInformación del alumno:");
            Console.WriteLine("Nombre: " + alumno1.Name);
            Console.WriteLine("Apellido: " + alumno1.Apellido);
            //Usamos métodos de datetime para convertir fechas en cadenas de texto 
            Console.WriteLine("Fecha de Nacimiento: " + alumno1.Fecha_Nac.ToShortDateString());
            Console.WriteLine("Teléfono: " + alumno1.Tel);
            Console.WriteLine("Dirección: " + alumno1.Direccion);
            Console.WriteLine("Carnet: " + alumno1.Carnet);
            Console.WriteLine("Fecha de Ingreso: " + alumno1.Fecha_Ingreso.ToShortDateString());
            Console.WriteLine("Carrera que cursa: "+ alumno1.Carrra_Ingreso);


            Profesor profesor1 = new Profesor(1, "Mirna", "Linares", new(1990,10,21), "54650497", "Colonia Linda Vista", "Licenciatura en Pedagogía",
                            "Jalapa, Jalapa", "0912-8891-9871");

            //Datos Profesor
            Console.WriteLine("\nInformación del Profesor:");
            Console.WriteLine("Nombre: " + profesor1.Name);
            Console.WriteLine("Apellido: " + profesor1.Apellido);
            //Usamos métodos de datetime para convertir fechas en cadenas de texto 
            Console.WriteLine("Fecha de Nacimiento: " + profesor1.Fecha_Nac.ToShortDateString());
            Console.WriteLine("Teléfono: " + profesor1.Tel);
            Console.WriteLine("Dirección: " + profesor1.Direccion);
            Console.WriteLine("Título: " + profesor1.Titulo);
            Console.WriteLine("Departamento: " + profesor1.Departamento);


        }

        //Referencias sobre el uso de datetime https://learn.microsoft.com/es-es/dotnet/api/system.datetime?view=net-8.0

    }
}