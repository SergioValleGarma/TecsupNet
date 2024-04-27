// See https://aka.ms/new-console-template for more information
using Clase20240424;

Console.WriteLine("Hello, World!");

Calculador calculador = new Calculador(new Cuadrado { lado = 20});
Calculador calculador2 = new Calculador(new Circulo { radio = 10 });

//IFigura figura = new Cuadrado();

Console.WriteLine(calculador.Area());
Console.WriteLine(calculador2.Area());

Console.ReadLine();
