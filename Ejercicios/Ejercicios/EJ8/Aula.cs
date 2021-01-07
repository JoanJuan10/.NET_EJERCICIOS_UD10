using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ8
{
    class Aula
    {
        private int numEstudiantesMaxima;
        private int numAlumnosActual;
        private int id;
        private string destinada;
        private Profesor profesor;
        private Alumno[] alumnos;

        public Aula(int numEstudiantesMaxima, int id, string destinada, Profesor profe)
        {
            this.numEstudiantesMaxima = numEstudiantesMaxima;
            this.id = id;
            this.destinada = destinada;
            this.profesor = profe;
            this.alumnos = new Alumno[numEstudiantesMaxima];
        }

        public int NumEstudiantesMaxima { get => numEstudiantesMaxima; set => numEstudiantesMaxima = value; }
        public int Id { get => id; set => id = value; }
        public string Destinada { get => destinada; set => destinada = value; }
        internal Profesor Profesor { get => profesor; set => profesor = value; }
        internal Alumno[] Alumnos { get => alumnos; set => alumnos = value; }

        public bool DarClase()
        {
            this.profesor.SeAusenta();
            if (this.profesor.Ausente)
            {
                return false;
            }
            int alumnosPresentes = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].SeAusenta();
                if (!alumnos[i].Novillo)
                {
                    alumnosPresentes++;
                }
            }
            if (alumnosPresentes > (this.numEstudiantesMaxima / 2))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
