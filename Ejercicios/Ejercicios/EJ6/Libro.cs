using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ6
{
    class Libro
    {
        private string ISBN;
        private string titulo;
        private string autor;
        private int numPaginas;

        public string ISBN1 { get => ISBN; set => ISBN = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public int NumPaginas { get => numPaginas; set => numPaginas = value; }

        public Libro(string iSBN, string titulo, string autor, int numPaginas)
        {
            this.ISBN = iSBN;
            this.titulo = titulo;
            this.autor = autor;
            this.numPaginas = numPaginas;
        }

        public string toString ()
        {
            return "El libro " + this.titulo + " con ISBN " + this.ISBN + " creado por " + this.autor + " tiene " + this.numPaginas + " paginas";
        }
    }
}
