using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio_3
{
    public class BMW : Auto
    {
        //Variables
        private string marca = "BMW";

        //Propiedad
        public string Modelo { get; set; }

        //Constructor
        public BMW(int hp, string color, string modelo) : base(hp, color)
        {
            this.Modelo = modelo;
        }

        //Métodos
        public new void MostrarDetalles()
        {
            Console.WriteLine("Marca: {0} - Modelo: {1} - HP: {2} - Color: {3}", marca, Modelo, HP, Color);
        }
        public override void Reparar()
        {
            base.Reparar();
            GuardarReparacionEnArchivo();
        }

        private void GuardarReparacionEnArchivo()
        {
            string reparacion = "Reparación de BMW realizada el " + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");

            // Especificar la ruta del archivo donde se almacenarán las reparaciones de BMW
            string filePath = "reparaciones_bmw.txt";

            try
            {
                using (StreamWriter writer = new StreamWriter(filePath, true))
                {
                    writer.WriteLine(reparacion);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al guardar la reparación en el archivo: " + e.Message);
            }
        }

        // Método nuevo para leer las reparaciones de BMW desde el archivo
        public new void HistoriaDeReparaciones()
        {
            Console.WriteLine("Historia de reparaciones de BMW:");
            // Especificar la ruta del archivo donde se almacenan las reparaciones de BMW
            string filePath = "reparaciones_bmw.txt";

            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error al leer el archivo de reparaciones de BMW: " + e.Message);
            }
        }
    }
}
