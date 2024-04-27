using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240426.Examen2
{
    public class ProveedoresRopa : IProveedores
    {
        public void EnviarPedidos(Pedidos pedidos)
        {
            Console.WriteLine("Enviar pedido de ropa");
        }
    }
}
