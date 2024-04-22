using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240412
{
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public double grade { get; set; }
        public Teacher teacher { get; set; }
    }
}
