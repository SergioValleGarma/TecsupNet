
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20240412
{
    public class Teacher
    {
        public int id { get; set; }
        public string name { get; set; }
        public string subject { get; set; }
        public List<Student> students { get; set; }
    }
}
