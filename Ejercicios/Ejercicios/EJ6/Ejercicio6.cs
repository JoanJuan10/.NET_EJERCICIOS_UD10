using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ6
{
    class Ejercicio6
    {
        public void Ejercicio ()
        {
            Libro lib1 = new Libro("6723895hws92","Mi vida como padre","Dark Vader", 666);
            Libro lib2 = new Libro("3478f2g78dq2", "1001 noches", "Calvito", 1001);

            Console.WriteLine(lib1.toString());
            Console.WriteLine(lib2.toString());

            if (lib1.NumPaginas < lib2.NumPaginas)
            {
                Console.WriteLine("El libro {0} es mayor al libro {1}", lib2.Titulo, lib1.Titulo);
            }
            else
            {
                Console.WriteLine("El libro {0} es mayor al libro {1}", lib1.Titulo, lib2.Titulo);
            }
        }
    }
}
