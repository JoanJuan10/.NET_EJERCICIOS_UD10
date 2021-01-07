using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ8
{
    class Alumno : Persona
    {
        private int calificacion;
        private bool novillo;


        public Alumno(string nombre, int edad, char sexo, int calificacion) : base (nombre, edad, sexo)
        {
            this.calificacion = calificacion;
        }

        public int Calificacion { get => calificacion; set => calificacion = value; }
        public bool Novillo { get => novillo; set => novillo = value; }

        public override void SeAusenta()
        {
            Random r = new Random();

            int porcNovillo = r.Next(1, 100);

            if (porcNovillo >= 50)
            {
                this.novillo = true;
            }
        }
    }
}
