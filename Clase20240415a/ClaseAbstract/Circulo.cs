using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240415a.ClaseAbstract
{
    public class Circulo : Figura
    {
        public double Radio { get; set; }
        public override double CalcularArea()
        {

            return Radio * Radio * 3.1416;

        }
    }
}
