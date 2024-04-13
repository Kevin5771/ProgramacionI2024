using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadorAcceso
{
    public class ClaseHeredada: Demostracion
    {
        public void metProtectedHeredado() {
            this.metProtectedHeredado();
        }
    }
}
