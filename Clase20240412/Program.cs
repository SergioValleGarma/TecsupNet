///////// prop de herencia
using Clase20240412.Herencia;

Vendedor vendedor = new()
{
    caja = 1,
    agencia = "Lima",
    sueldo = 700.50d,
    nombres = "Juan Carlo",
    apellidos = "Rojas Flores",
    DNI = "12345678"
};

//foreach (Vendedor item in Vendedor.ReferenceEquals(vendedor))
//{
//    Console.WriteLine($"caja {vendedor.caja} \nagencia {vendedor.agencia}");
//}

Console.WriteLine($"caja {vendedor.caja} \nagencia {vendedor.agencia}");

Console.ReadLine();
