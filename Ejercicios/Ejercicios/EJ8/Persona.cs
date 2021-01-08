using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ8
{
    public abstract class Persona
    {
        private string nombre;
        private int edad;
        private char sexo;

        protected string Nombre { get => nombre; set => nombre = value; }
        protected int Edad { get => edad; set => edad = value; }
        protected char Sexo { get => sexo; set => sexo = value; }

        protected Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
        }

        public abstract void SeAusenta();
    }
}
