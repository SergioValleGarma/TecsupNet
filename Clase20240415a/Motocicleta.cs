using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240415a
{
    public class Motocicleta : Vehiculo
    {
        public double preioVenta { get; set; }
        public override double PrecioVanta()
        {
            return preioVenta;
        }
    }
}
