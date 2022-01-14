using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Alumnos>(); // El contenedor
            for (int i = 1; i <= 10; i++)
            {
                var alumno = new Alumnos
                {
                    Id = i,
                    Nombre = " Pepe " + i
                };
                lista.Add(alumno);
            }


            foreach (var a in lista)
            {
                Console.WriteLine($"El id es : {a.Id} el nombre es:{a.Nombre} ");
            }
            Console.ReadKey();
        }
    }
}
