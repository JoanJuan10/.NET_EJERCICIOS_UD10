using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ5
{
    class Ejercicio5
    {
        public void Ejercicio ()
        {
            Serie[] arr1 = new Serie[5];
            Videojuego[] arr2 = new Videojuego[5];

            arr1[0] = new Serie("RED",1,"Accion","Yo");
            arr1[1] = new Serie("RED 2", 2, "Aventura-Accion", "Eduard");
            arr1[2] = new Serie("Marmaduke", 2, "Ficcion", "La vecina");
            arr1[3] = new Serie("Doraemon", 10, "Ficcion", "Bartomeu");
            arr1[4] = new Serie("Los Simpson", 300, "Ficcion", "Matt Groening");

            arr2[0] = new Videojuego("CSGO",10,"Shooter","Valve");
            arr2[1] = new Videojuego("GTA 5", 50, "Accion", "Rockstar");
            arr2[2] = new Videojuego("Path of Exile", 5, "Aventura", "Eduard");
            arr2[3] = new Videojuego("League of Legends", 100, "MOBA", "Riot Games");
            arr2[4] = new Videojuego("Clash of Clans",1);

            arr1[1].Entregar();
            arr1[4].Entregar();

            arr2[1].Entregar();
            arr2[3].Entregar();

            int masTemporadas = 0;
            int masHoras = 0;

            for (int i = 1; i < arr1.Length; i++)
            {
                if(arr1[i].CompareTo(arr1[masTemporadas]))
                {
                    masTemporadas = i;
                }
            }
            for (int i = 1; i < arr1.Length; i++)
            {
                if (arr1[i].CompareTo(arr1[masHoras]))
                {
                    masHoras = i;
                }
            }
            Console.WriteLine(arr1[masTemporadas].toString());
            Console.WriteLine(arr2[masHoras].toString());
        }
    }
}
