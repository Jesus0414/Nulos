using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Alumno
    {
        public string Nombre { get; set; }
        public string Matricula { get; set; }
        public List<string> Materias { get; set; }
        public Alumno()
        {
            Materias = new List<string>();
        }
    }
}
