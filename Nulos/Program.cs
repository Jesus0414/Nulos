using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nulos
{
    class Program
    {
        static Alumno alumno;
        static void Main(string[] args)
        {
            alumno = new Alumno();
            //alumno.Materias.Add("Matematicas");
            imprimirAlumno();
            Console.Read();
        }
        static void imprimirAlumno()
        {
            try
            {
                alumno.Nombre = "Jesús";
                Console.WriteLine("Nombre: " + alumno.Nombre);
                //alumno = null;
            }catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}
