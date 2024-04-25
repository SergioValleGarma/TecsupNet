using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240422
{
    public class Descuento
    {
        public decimal AplicarDescuento(decimal precio, string tipoCliente)
        {
            if (tipoCliente == "Regular")
            {
                return precio * 0.9m;
            }
            else if (tipoCliente == "VIP")
            {
                return precio * 0.8m;
            }
            else
            {
                return precio;
            }
        }
    }

    abstract class Venta
    {
        public decimal precio { get; set; }
        public abstract decimal AplicarDescuento(decimal precio, string tipoCliente);
    }

    class VentaRegular : Venta
    {
        public override decimal AplicarDescuento(decimal precio, string tipoCliente)
        {
            return precio * 0.9m;
        }
    }

    class VentaVIP : Venta
    {
        public override decimal AplicarDescuento(decimal precio, string tipoCliente)
        {
            return precio * 0.8m;
        }
    }
}
