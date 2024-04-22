using Clase20240417.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240417.Abstract
{
    public abstract class Empleado : IEmpleado
    {
        public string nombre { get; set; }
        public int idEmpleado { get; set; }
        public string puesto { get; set; }
        public double SueldoNeto { get; set; }

        public abstract double sueldoBase { get; }

        public abstract void calcularSueldo();

        public virtual void mostrarDetalles()
        {
            throw new NotImplementedException();
        }
    }
}
