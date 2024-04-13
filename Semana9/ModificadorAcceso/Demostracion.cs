using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAcceso
{

 
    public class Demostracion
    {
        enum Dia { Lu, Ma, Mi, Ju, Vi, Sa, Do }
        public void Prueba()
        {
            Class1 objetoPrueba = new Class1();  
        }
        private int id;
        public string name;
        private DateTime fechaNac = new DateTime(1990, 01, 01);
        private void metodoPrivate() {
            Console.WriteLine("Esto es Privado");
        }

        public int ObtenerEdad() { 
            return Convert.ToInt32((DateTime.Now - fechaNac).TotalDays/365);
        }

        public void CmabiarFechNac(DateTime nuevafecha)
        {
            this.fechaNac = nuevafecha;
        }
        protected void MetodoPrtected()
        {
            Console.WriteLine("Este método usa Protected");
        }


        public void EjemploEnum(int dia)
        {
            if(dia == (int)Dia.Sa){
                Console.WriteLine("Yes");
            }
        }


        
    }
}
