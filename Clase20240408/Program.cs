using Clase20240408;

class Program
{
    static void Main()
    {
        Console.WriteLine("hola mundo");

        Cuadrado cuadrado = new Cuadrado();
        cuadrado.lado = 10;

        Console.WriteLine("El area del cuadradodo es: ");
        Console.WriteLine(cuadrado.Calcular());

        Persona oPer = new Persona()
        {
            nombre = "Luis Mario",
            apellido = "Carranza Rojas",
            edad = 40
        };   
        
        Console.WriteLine("el nombre completo es "+ oPer.NombreCompleto());

        List<Empleado> empleados = new List<Empleado>();
        string nom = "";
        double sal = 0;
        string dep = "";
        string salir = "";

        do
        {
            Console.WriteLine("Ingrese el nombre");
            nom =Console.ReadLine();
            Console.WriteLine("Ingrese el salario");
            sal = Convert.ToDouble( Console.ReadLine());
            Console.WriteLine("Ingrese el departamento");
            dep = Console.ReadLine();

            Empleado empleado = new Empleado(nom,sal,dep);
            empleados.Add(empleado);

            Console.WriteLine("Desea salir?");
            salir= Console.ReadLine();

        } while (salir.ToUpper() != "S");

        foreach (var item in empleados)
        {
            Console.WriteLine($"Nombre: {item.Nombre} Salario: {item.Salario} Departamento: {item.Departameto}");
        }

    }

}