using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD
{
    public class Ventas
    {
        public int Id { get; set; }
        public string Cliente { get; set; }
        public string NombreProducto { get; set; }
        public int cantidad { get; set; }
        public int Precio { get; set; }
        public string Idproducto { get; set; }

    }
}
