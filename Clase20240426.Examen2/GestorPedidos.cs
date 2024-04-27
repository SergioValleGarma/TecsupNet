using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240426.Examen2
{
    public class GestorPedidos
    {
        private readonly IProveedores _proveedores;
        private  Pedidos _pedido;

        public GestorPedidos (Pedidos pedido,IProveedores proveedores)
        {
            _pedido = pedido;
            _proveedores = proveedores;
        }

        public void EnviarPedidoTipoProducto()
        {
            _proveedores.EnviarPedidos(_pedido);
        }
    }
}
