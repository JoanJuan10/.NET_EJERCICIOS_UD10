using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ5
{
    class Serie : Entregable
    {
        private string titulo;
        private int temporadas = 3;
        private string genero;
        private string creador;
        private bool entregado = false;

        public Serie()
        {
        }

        public Serie(string titulo, string creador)
        {
            this.titulo = titulo;
            this.creador = creador;
        }

        public Serie(string titulo, int temporadas, string genero, string creador)
        {
            this.titulo = titulo;
            this.temporadas = temporadas;
            this.genero = genero;
            this.creador = creador;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int Temporadas { get => temporadas; set => temporadas = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Creador { get => creador; set => creador = value; }

        public string toString ()
        {
            return "Titulo: " + this.titulo +
                "Temporadas: " + this.temporadas +
                "Entregado: " + this.entregado +
                "Genero: " + this.genero +
                "Creador: " + this.creador;
        }
        public void Entregar()
        {
            this.entregado = true;
        }
        public void Devolver()
        {
            this.entregado = false;
        }
        public bool IsEntregado()
        {
            return this.entregado;
        }
        public bool CompareTo(Object a)
        {
            Serie serie = (Serie)a;
            if (serie.Temporadas == this.temporadas)
            {
                return true;
            }
            return false;
        }
    }
}
