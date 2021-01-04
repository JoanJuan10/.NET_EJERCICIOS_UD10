using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ3
{
    class Ejercicio3
    {
        public void Ejercicio ()
        {
            Console.WriteLine("Elige la cantidad de contraseñas:");
            int tam = Convert.ToInt32(Console.ReadLine());
            Password[] contraseñas = new Password[tam];
            bool[] seguro = new bool[tam];

            Console.WriteLine("Elige la medida de las contraseñas:");
            int passTam = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < contraseñas.Length; i++)
            {
                contraseñas[i] = new Password(passTam);
                seguro[i] = contraseñas[i].EsFuerte();

                Console.WriteLine(contraseñas[i].Contraseña + " " + seguro[i]);
            }

        }
    }
}
