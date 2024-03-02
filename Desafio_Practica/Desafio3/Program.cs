
using System;

namespace Desafio3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Alumno> list = new List<Alumno>();
            bool active = true;


            while (active = true) {

                Console.WriteLine("\n--- Sistema de Gestión de Estudiantes ---");
                Console.WriteLine("1. Registrar un nuevo estudiante");
                Console.WriteLine("2. Actualizar la información de un estudiante");
                Console.WriteLine("3. Buscar un estudiante por su número de identificación");
                Console.WriteLine("4. Mostrar la lista de todos los estudiantes registrados");
                Console.WriteLine("5. Salir del programa");
                Console.Write("Ingrese su opción: ");

                byte op = byte.Parse(Console.ReadLine());

                switch (op) {
                    case 1:
                        Console.WriteLine("Ingrese el nombre del Alumno:");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Ingrese el apellido del Alumno:");
                        string apellido = Console.ReadLine();
                        Console.WriteLine("Ingrese el Id del Alumno:");
                        byte id = byte.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese el grado del Alumno:");
                        int grade = int.Parse(Console.ReadLine());

                        Alumno newStudent = new Alumno(nombre, apellido, id, grade);
                        list.Add(newStudent);
                        Console.WriteLine("¡Estudiante registrado exitosamente!");

                        break;

                    case 2:
                        Console.Write("Ingrese el número de identificación del estudiante que desea actualizar: ");
                        int updateID = int.Parse(Console.ReadLine());
                        Alumno actEstudiante = list.Find(s => s.ID == updateID);
                        if (actEstudiante != null)
                        {
                            Console.Write("Ingrese el nuevo primer nombre del estudiante: ");
                            string newName = Console.ReadLine();
                            Console.Write("Ingrese el nuevo apellido del estudiante: ");
                            string newApellido = Console.ReadLine();
                            Console.Write("Ingrese el nuevo grado del estudiante: ");
                            int newGrade = int.Parse(Console.ReadLine());

                            actEstudiante.UpdateStudent(newName, newApellido, newGrade);
                            Console.WriteLine("¡Información del estudiante actualizada correctamente!");
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ningún estudiante con ese número de identificación.");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Ingrese el número de identificación del estudiante que desea buscar: ");
                        int searchID = int.Parse(Console.ReadLine());
                        Alumno SeacrhAlumno = list.Find(s => s.ID == searchID);
                        if (SeacrhAlumno!= null)
                        {
                            Console.WriteLine("Información del estudiante encontrado:");
                            Console.WriteLine(SeacrhAlumno.ToString());
                        }
                        else
                        {
                            Console.WriteLine("No se encontró ningún estudiante con ese número de identificación.");
                        }
                        break;
                    case 4:
                        Console.WriteLine("Estudiantes Registrados:");
                        foreach(Alumno search in list)
                        {
                            Console.WriteLine(list.ToString());
                        }
                        break;
                    case 5:
                        Console.WriteLine("¡Gracias por usar el sistema de gestión de estudiantes!");
                        active = false;
                        break;

                }
            }


        }
    }
}