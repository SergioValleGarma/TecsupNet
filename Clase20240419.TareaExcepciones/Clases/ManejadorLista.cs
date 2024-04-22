using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240419.TareaExcepciones.Clases
{
    public class ManejadorLista
    {
        private List<int> lista { get; set; } = new List<int> { 1 };
        public void eliminarElemento()
        {
            try
            {
                lista.Remove(lista[lista.Count() - 1]);
                Console.WriteLine("Se elimino el último elemento de la lista");
            }
            catch (InvalidOperationException)
            {

                throw new InvalidOperationException("El error se produjo en la clase ManejadorLista");
            }
        }

        public void agregarElemento(int elemento)
        {
            lista.Add(elemento);
            Console.WriteLine("Se agrego elemeto");
        }

        public void mostrarEelemto()
        {
            foreach (var item in lista)
            {
                Console.WriteLine("Se muestra elemento :" + item + " \n");
            }
        }
    }
}
