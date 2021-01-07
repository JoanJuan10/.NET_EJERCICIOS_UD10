using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ8
{
    class Profesor : Persona
    {
        private string materia;
        private bool ausente;

        public Profesor(string nombre, int edad, char sexo, string materia) : base (nombre, edad, sexo)
        {
            this.materia = materia;
        }

        public string Materia { get => materia; set => materia = value; }
        public bool Ausente { get => ausente; set => ausente = value; }

        public override void SeAusenta ()
        {
            Random r = new Random();

            int porcAusente = r.Next(1, 100);

            if (porcAusente <= 20)
            {
                this.ausente = true;
            }
        }
    }
}
