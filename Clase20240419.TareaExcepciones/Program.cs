using Clase20240419.TareaExcepciones.Clases;
using Clase20240419.TareaExcepciones.Funciones;

internal class Program
{
    private static void Main(string[] args)
    {
        void pintarMenu()
        {
            Console.WriteLine("\n");
            Console.WriteLine("Menu de opciones: ");
            Console.WriteLine("===========================");
            Console.WriteLine("1. División entre cero:");
            Console.WriteLine("2. Operación inválida en lista vacía:");
            Console.WriteLine("3: Calcular la suma de los primeros 100 números naturales.");
            Console.WriteLine("4: Imprimir todos los números desde 1 hasta el número ingresado por el usuario.");
            Console.WriteLine("5: Calcular el área de un círculo utilizando el radio ingresado por el usuario.");
            Console.WriteLine("6: Salir");
            Console.WriteLine("===========================\n");
        }

        
        try
        {
            int opcion = 0;

            do
            {
                pintarMenu();
                Console.WriteLine("\nSeleciones una opción y presione enter.");
                string opcionString = Console.ReadLine();
                bool reult = int.TryParse(opcionString, out opcion);
                if (reult)
                {
                    switch (opcion)
                    {
                        case 1:
                            Console.WriteLine("seleccionó la opcion 01");
                            funcionInput();                            
                            break;
                        case 2:
                            Console.WriteLine("seleccionó la opcion 02");                            
                            funcionInput2();
                            
                            break;
                        case 3:
                            Console.WriteLine("seleccionó la opcion 03");
                            ///Suma100Numeros();
                            break;
                        case 4:
                            Console.WriteLine("seleccionó la opcion 04");
                            ///ImprimirNumeros();
                            break;
                        case 5:
                            Console.WriteLine("seleccionó la opcion 05");
                            //CalcularAreaCirculo();
                            break;
                        case 6:
                            Console.WriteLine("seleccionó salir");
                            break;
                        default:
                            Console.WriteLine("Opcion erronea, por favor seleciones del 1 al 6");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Usted no selecciono un numero");
                }

                

            } while (opcion != 8);
        }
        catch (Exception ex)
        {

            throw new Exception("Error de compilacion : contactarse con el soporte tecnico \nMensaje de error: \n" + ex);
        }
        finally
        {
            Console.ReadLine();
        }
    }

    public static void funcionInput2()
    {
        try
        {
            Console.WriteLine("Ingrese 1 si quiere agregar un elemento a la lista\n" +
                "Ingrese 2 si quiere eliminar un elemento a la lista");
            string opcion = Console.ReadLine();
            bool resp = int.TryParse(opcion, out int iOpcion);
            if (resp) {
                ManejadorLista manejadorLista = new ManejadorLista();
                switch (iOpcion)
                {
                    case <0:
                        Console.WriteLine("Opcion erronea");
                        break;
                    case 1:
                        Console.WriteLine("Ingrese un numero como elemento");
                        int elemento= Convert.ToInt32(Console.ReadLine());
                        manejadorLista.agregarElemento(elemento);
                        manejadorLista.mostrarEelemto();
                        break;
                    case 2:
                        Console.WriteLine("Se boorara un elemto elemento");
                        manejadorLista.eliminarElemento();
                        manejadorLista.mostrarEelemto();
                        break;
                    case >=3:
                        Console.WriteLine("Opcion erronea");
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Usted no selecciono un numero");
            };
        }
        catch (Exception e)
        {

            throw new Exception("Error en funcionInput2 "+e);
        };
    }

    public static void funcionInput()
    {
        try
        {
        Console.WriteLine("Ingrese el numerador");
        string sNum1 = Console.ReadLine();
        Console.WriteLine("Ingrese el denominador");
        string sNum2 = Console.ReadLine();
        bool res1 = int.TryParse(sNum1, out int dNum1);
        bool res2 = int.TryParse(sNum2, out int dNum2);
        if (res1 && res2)
            {
                Matematica matematica = new Matematica();  
                matematica.Division(dNum1,dNum2);
            }
            else 
            {
                Console.WriteLine("Usted no ingresoun valor numreico");
            }


        }
        catch (Exception ex)
        {
            throw new Exception("Error en la funcion deingreso de numeros "+ ex);
        }
        
    }
}