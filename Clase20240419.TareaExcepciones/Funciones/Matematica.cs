using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240419.TareaExcepciones.Funciones
{
    public class Matematica
    {
        public double numero1 { get; set; }
        public double numero2 { get; set; }
        public string operacion { get; set; }
        public double resultado { get; set; }

        public void Suma()
        {
            resultado= numero1 + numero2;
            Console.WriteLine(resultado);
        }

        public void Division(int dNumero1, int dNumero2)
        {
            try
            {
                int nu1 = dNumero1;
                int nu2 = dNumero2;
                double respuesta = nu1 / nu2; //// dNumero1 / dNumero2;
                Console.WriteLine($"El resultado de la division es: {respuesta}");
                ///return respuesta;
            }
            catch (DivideByZeroException ex)
            {

                throw new DivideByZeroException("Error en la división " + ex);
            }
        }

    }
}
