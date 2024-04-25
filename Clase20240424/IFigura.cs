using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240424
{
    public interface IFigura
    {
        public double CalcularArea();
    }

    public class Cuadrado : IFigura
    {
        public double lado {  get; set; }
        public double CalcularArea()
        {
            return lado * lado;
        }
    }

    public class Circulo : IFigura
    {
        public double radio { get; set; }
        public double CalcularArea()
        {
            return Math.PI * radio * radio;
        }
    }

    public class Calculador
    {
        private readonly IFigura _figura;
        public Calculador(IFigura figura) 
        { 
            _figura = figura;
        }

        public double Area()
        {
            return _figura.CalcularArea();
        }
    }
}
