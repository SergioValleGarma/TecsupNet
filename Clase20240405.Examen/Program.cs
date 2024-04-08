// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
/* Crea un programa en C# que presente un menú con las siguientes opciones:
1 Determinar si un número ingresado por el usuario es positivo, negativo o cero. 
Esta funcionalidad debe implementarse como una función.
2 Imprimir un mensaje según el día de la semana ingresado por el usuario. 
Este proceso debe implementarse como un procedimiento.

3 Calcular la suma de los primeros 100 números naturales. 
Este cálculo debe implementarse como una función.

4 Imprimir todos los números desde 1 hasta el número ingresado por el usuario. 
Este proceso debe implementarse como un procedimiento.

5 Calcular el área de un círculo utilizando el radio ingresado por el usuario. 
Este cálculo debe implementarse como una función.

6 Mostrar los elementos de un arreglo unidimensional predefinido. 
Este proceso debe implementarse como un procedimiento.

7 Mostrar nombres de personas almacenados en una lista predefinida. 
Este proceso debe implementarse como un procedimiento.

8 Salir

El programa debe permitir al usuario seleccionar una opción del menú. Cada opción debe llamar a la función o procedimiento correspondiente y mostrar el resultado en la consola.
Cuando terminas de ejecutar una de las opciones, nuevamente te debe salir el Menú.
El programa solo debe terminar cuando le das la opción 8 de Salir

 */

using static System.Runtime.InteropServices.JavaScript.JSType;

void pintarMenu()
{
    Console.WriteLine("\n");
    Console.WriteLine("Menu de opciones: ");
    Console.WriteLine("===========================");
    Console.WriteLine("1: Determinar si un número ingresado por el usuario es positivo, negativo o cero.");
    Console.WriteLine("2: Imprimir un mensaje según el día de la semana ingresado por el usuario.");
    Console.WriteLine("3: Calcular la suma de los primeros 100 números naturales.");
    Console.WriteLine("4: Imprimir todos los números desde 1 hasta el número ingresado por el usuario.");
    Console.WriteLine("5: Calcular el área de un círculo utilizando el radio ingresado por el usuario.");
    Console.WriteLine("6: Mostrar los elementos de un arreglo unidimensional predefinido.");
    Console.WriteLine("7: Mostrar nombres de personas almacenados en una lista predefinida.");
    Console.WriteLine("8: Salir");
    Console.WriteLine("===========================\n");
}

int opcion;

do
{
    pintarMenu();

    Console.WriteLine("\nSeleciones una opción y presione enter.");

    opcion = Convert.ToInt32(Console.ReadLine());

    switch (opcion)
    {
        case 1:
            Console.WriteLine("seleccionó la opcion 01");
            DeterminarPositivo();
            break;
        case 2:
            Console.WriteLine("seleccionó la opcion 02");
            DiaSemana();
            break;
        case 3:
            Console.WriteLine("seleccionó la opcion 03");
            Suma100Numeros();
            break;
        case 4:
            Console.WriteLine("seleccionó la opcion 04");
            ImprimirNumeros();
            break;
        case 5:
            Console.WriteLine("seleccionó la opcion 05");
            CalcularAreaCirculo();
            break;
        case 6:
            Console.WriteLine("seleccionó la opcion 06");
            MostrarElementos();
            break;
        case 7:
            Console.WriteLine("seleccionó la opcion 07");
            MostrarElementosLista();
            break;
        case 8:
            Console.WriteLine("seleccionó salir");
            break;
        default:
            Console.WriteLine("Opcion erronea, por favor seleciones del 1 al 6");
            break;
    }

} while (opcion != 8);

void DeterminarPositivo(){
    Console.WriteLine("Por favor ingrese un numero");
    int positivo= Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(_DeterminarPositivo(positivo));
}

string _DeterminarPositivo(int numero)
{
    string mensaje= "el valor ingresado no es correcto";
    switch (numero)
    {
        case < 0:
            mensaje = "El numero ingresado es negativo.";
            break;
        case 0:
            mensaje = "El numero ingresado es cero.";
            break;
        case > 0:
            mensaje = "El numero ingresado es positivo.";
            break;
        default:
            break;
    }
    return mensaje;
}

void DiaSemana(){
    Console.WriteLine("Por favor, ingrese un dia de la semana");
    string dia = "";
    dia = Console.ReadLine().ToUpper();
    switch (dia)
    {
        case "LUNES":
            Console.WriteLine("Usted seleciono el dia lunes");
            break;
        case "MARTES":
            Console.WriteLine("Usted seleciono el dia martes");
            break;
        case "MIERCOLES":
            Console.WriteLine("Usted seleciono el dia miercoles");
            break;
        case "JUEVES":
            Console.WriteLine("Usted seleciono el dia jueves");
            break;
        case "VIERNES":
            Console.WriteLine("Usted seleciono el dia viernes");
            break;
        case "SABADO":
            Console.WriteLine("Usted seleciono el dia sabado");
            break;
        case "DOMINGO":
            Console.WriteLine("Usted seleciono el dia domingo");
            break;
        default:
            Console.WriteLine("El dia ingresado es incorrecto");
            break;
    }

}

void Suma100Numeros()
{
    int resultado = _Suma100Numeros();

    Console.WriteLine("la suma de los 100 primero numero es " + resultado);
}

int _Suma100Numeros()
{
    int acumulador = 0;
    for (int i = 0; i < 101; i++)
    {
        acumulador += i;
    }
    return acumulador;
}

void ImprimirNumeros(){
    Console.WriteLine("Por favor ingrese un numero");
    int numero = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("\n");
    for (int i = 1; i < numero+1; i++)
    {
        Console.WriteLine(i);
    }
    
}

void CalcularAreaCirculo()
{
    Console.WriteLine("Por favor, ingrese el radio del circulo.");
    int radio = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(_CalcularAreaCirculo(radio));

}

double _CalcularAreaCirculo(int radio)
{
    double resultado = Math.PI*radio*radio;
    return resultado;
}

void MostrarElementos()
{
    string[] arreglo = { "uno", "dos", "tres", "cuatro" };
    foreach (var item in arreglo)
    {
        Console.WriteLine(item);
    }
};

void MostrarElementosLista()
{
    List<string> lista = new List<string> { "Juan","Martin","Luis","Carlos"};
    foreach (var item in lista)
    {
        Console.WriteLine(item);
    }
};

