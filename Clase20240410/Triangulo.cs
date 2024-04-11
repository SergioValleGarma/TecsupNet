using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240410
{
    public class Triangulo
    {
        public Punto Punto1 { get; set; }
        public Punto Punto2 { get; set; }
        public Punto Punto3 { get; set; }

        public Triangulo()
        {

        }

        public Triangulo(Punto punto1, Punto punto2, Punto punto3)
        {
            Punto1 = punto1;
            Punto2 = punto2;
            Punto3 = punto3;

        }




        #region FuncionesPrivadas

        //private double CalcularDistancia(double a1, double b1, double a2, double b2)
        //{
        //    double result;
        //    result = Math.Sqrt(Math.Pow((a2 - a1), 2) + Math.Pow((b2 - b1), 2));
        //    return result;

        //}
        //Helper helper = new Helper();
        private double ObtenerAltura()
        {
            double result;
            result = Helper.CalcularDistancia(Punto1.X, Punto1.Y, Punto2.X, Punto2.Y);
            return result;
        }
        private double ObtenerBase()
        {
            double result;
            result = Helper.CalcularDistancia(Punto1.X, Punto1.Y, Punto3.X, Punto3.Y);
            return result;
        }

        private double ObtenerDiagonal()
        {
            double result;
            result = Helper.CalcularDistancia(Punto2.X, Punto2.Y, Punto3.X, Punto3.Y);
            return result;
        }

        #endregion

        #region FuncionesPublicas

        public double CalcularArea()
        {
            double result;
            result = ObtenerBase() * ObtenerAltura()/2;
            return result;
        }

        public double CalcularPerimetro()
        {
            double result;
            result = ObtenerBase() + ObtenerAltura() + ObtenerDiagonal();
            return result;
        }
        #endregion



    


}
}
