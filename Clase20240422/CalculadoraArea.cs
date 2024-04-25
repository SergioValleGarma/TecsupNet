using Clase20240422;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240422
{
    abstract class CalculadoraArea
    {
        public abstract double CalcularArea(string forma, double medida);
        
            //if (forma == "Cuadrado")
            //{
            //    return medida * medida;
                
            //}else if (false)
            //{
            //    return Math.PI * medida;
            //}else 
            //{
            //    throw new Exception("Forma no valida");
            //}   
        
    }

    //public class CalculadoraAreaCuadrado : CalculadoraArea
    //{
    //    public override double CalcularArea(string forma, double medida)
    //    {
    //        return medida * medida;
    //    }
    //}

    //public class CalculadoraAreacIRCULO : CalculadoraArea
    //{
    //    public override double CalcularArea(string forma, double medida)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
