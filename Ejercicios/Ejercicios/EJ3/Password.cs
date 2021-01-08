using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ3
{
    class Password
    {
        private int longitud = 8;
        private string contraseña;

        public Password()
        {
        }

        public Password(int longitud)
        {
            Random r = new Random();
            this.contraseña = "";

            for (int i = 0; i < this.longitud; i++)
            {
                contraseña += Convert.ToChar(Convert.ToInt32(26 * r.NextDouble() + 65)).ToString();
            }

        }

        public int Longitud { get => longitud; set => longitud = value; }
        public string Contraseña { get => contraseña; }

        public bool EsFuerte ()
        {
            int mayus = 0;
            int numeros = 0;
            int minus = 0;
            for (int i = 0; i < this.contraseña.Length; i++)
            {
                if (Char.IsDigit(this.contraseña[i]))
                {
                    numeros++;
                }
                else if (this.contraseña[i] == Char.ToLower(this.contraseña[i]))
                {
                    minus++;
                }
                else if (this.contraseña[i] == Char.ToUpper(this.contraseña[i]))
                {
                    mayus++;
                }

            }
            if (mayus >= 2 && minus >= 1 && numeros >= 5)
            {
                return true;
            }
            return false;
        }
    }
}
