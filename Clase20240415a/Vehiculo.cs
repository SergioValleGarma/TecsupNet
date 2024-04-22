using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240415a
{
    public abstract class Vehiculo
    {
        public string marca { get; set; }
        public string modelo { get; set; }

        public abstract double PrecioVanta();
    }
}
