namespace Clase20240408
{
    struct Empleado
    {
        public string Nombre;
        public double Salario;
        public string Departameto;

        public Empleado(string nombre, double salario, string departamento) {
            this.Nombre = nombre;
            this.Salario = salario;
            this.Departameto = departamento;
        }
    }
}
