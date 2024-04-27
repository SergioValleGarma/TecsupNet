// See https://aka.ms/new-console-template for more information
using Clase20240426.Examen2;

Console.WriteLine("Hello, World!");

GestorPedidos gestorPedidos = new GestorPedidos(new Pedidos(),new ProveedoresElectronicos());
GestorPedidos gestorPedidos2 = new GestorPedidos(new Pedidos(), new ProveedoresRopa());

gestorPedidos.EnviarPedidoTipoProducto();
gestorPedidos2.EnviarPedidoTipoProducto();

Console.ReadLine();
