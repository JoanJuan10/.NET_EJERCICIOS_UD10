using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ5
{
    class Videojuego : Entregable
    {
        private string titulo;
        private int horasEstimadas = 10;
        private string genero;
        private string compañia;
        private bool entregado = false;

        public Videojuego()
        {
        }

        public Videojuego(string titulo, int horasEstimadas)
        {
            this.titulo = titulo;
            this.horasEstimadas = horasEstimadas;
        }

        public Videojuego(string titulo, int horasEstimadas, string genero, string compañia) : this(titulo, horasEstimadas)
        {
            this.genero = genero;
            this.compañia = compañia;
        }

        public string Titulo { get => titulo; set => titulo = value; }
        public int HorasEstimadas { get => horasEstimadas; set => horasEstimadas = value; }
        public string Genero { get => genero; set => genero = value; }
        public string Compañia { get => compañia; set => compañia = value; }

        public string toString()
        {
            return "Titulo: " + this.titulo +
                "Horas estimadas: " + this.horasEstimadas +
                "Entregado: " + this.entregado +
                "Genero: " + this.genero +
                "Compañia: " + this.compañia;
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
        public bool CompareTo (Object a)
        {
            Videojuego videojuego = (Videojuego)a;
            if (videojuego.HorasEstimadas < this.HorasEstimadas)
            {
                return true;
            }
            return false;
        }
    }
}
