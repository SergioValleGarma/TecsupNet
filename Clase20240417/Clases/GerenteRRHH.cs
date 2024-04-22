using Clase20240417.Abstract;
using Clase20240417.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240417.Clases
{
    public class GerenteRRHH : Empleado, IDescuentoImpuesto
    {
        public override double sueldoBase => throw new NotImplementedException();

        public override void calcularSueldo()
        {
            throw new NotImplementedException();
        }

        public void DescontarSueldo()
        {
            throw new NotImplementedException();
        }
    }
}
