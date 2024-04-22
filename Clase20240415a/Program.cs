using Clase20240415a;
using Clase20240415a.Polimorfismo;
using System;
using System.Collections.Generic;


class Program
{
    static void Main(string[] args)
    {
        #region
        //List<Trabajador> listaTrabajadores = new List<Trabajador>();

        //Trabajador trabajador1 = new Trabajador
        //{
        //    Nombre = "Hugo",
        //    SalarioBase = 12000
        //};
        //trabajador1.MostrarInformacion();

        //TrabajadorPorHora trabajadorPorHora = new TrabajadorPorHora
        //{
        //    Nombre = "Juan",
        //    SalarioBase = 2500m,
        //    HorasTrabajadas = 40,
        //    PrecioHora = 20m
        //};

        //TrabajadorAsalariado trabajadorAsalariado = new TrabajadorAsalariado
        //{
        //    Nombre = "María",
        //    SalarioBase = 3000m
        //};

        //listaTrabajadores.Add(trabajador1);//Objeto del padre
        //listaTrabajadores.Add(trabajadorPorHora);//Objeto del hijo
        //listaTrabajadores.Add(trabajadorAsalariado);//Objeto del hijo


        //foreach (Trabajador trabajador in listaTrabajadores)
        //{
        //    decimal sueldo = trabajador.CalcularSueldo();
        //    trabajador.MostrarInformacion();
        //    Console.WriteLine($"Sueldo: {sueldo}");
        //    Console.WriteLine();
        //}
        #endregion

        #region

        Vehiculo vehiculo = new Automovil
        {
            preioVenta = 12000d
        };
        //vehiculo.PrecioVanta();



        #endregion

        Console.Read();
    }
}

