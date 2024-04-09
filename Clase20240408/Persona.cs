using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240408
{
    struct Persona
    {
        public string nombre;
        public string apellido;
        public int edad;

        public string NombreCompleto()
        { 
            return nombre +" " + apellido; 
        }  
    }
}
