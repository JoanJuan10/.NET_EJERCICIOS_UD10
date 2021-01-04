using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ2
{
    class Persona
    {
        private string nombre;
        private int edad;
        private string dni;
        private char sexo;
        private double peso;
        private double altura;


        public Persona()
        {
            const char sexoDefault = 'H';

            this.nombre = "";
            this.edad = 0;
            this.sexo = sexoDefault;
            this.peso = 0;
            this.altura = 0;
            GeneraDNI();

        }

        public Persona(string nombre, int edad, char sexo)
        {
            this.nombre = nombre;
            this.edad = edad;
            this.sexo = sexo;
            this.peso = 0;
            this.altura = 0;
            GeneraDNI();
        }

        public Persona(string nombre, int edad, char sexo, double peso, double altura)
        {
            this.nombre = nombre;
            this.edad = edad;
            GeneraDNI();
            this.sexo = sexo;
            this.peso = peso;
            this.altura = altura;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Dni { get => dni }
        public char Sexo { get => sexo; set => sexo = value; }
        public double Peso { get => peso; set => peso = value; }
        public double Altura { get => altura; set => altura = value; }

        public int CalcularIMC ()
        {
            if (this.peso / Math.Pow(this.altura,2) < 20)
            {
                return -1;
            }
            else if (this.peso / Math.Pow(this.altura, 2) >= 20 && this.peso / Math.Pow(this.altura, 2) <= 25)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public bool EsMayorDeEdad ()
        {
            if (this.edad < 18)
            {
                return false;
            }
            return true;
        }
        private void ComprobarSexo (char sexo)
        {
            if (sexo == 'H' || sexo == 'M')
            {
                this.sexo = sexo;
            }
            else
            {
                this.sexo = 'H';
            }
        }
        public string toString ()
        {
            return "Nombre: " + this.nombre +
                "Edad: " + this.edad +
                "DNI: " + this.dni +
                "Sexo: " + this.sexo +
                "Peso: " + this.peso +
                "Altura: " + this.altura;
        }
        public void GeneraDNI ()
        {
            Random r = new Random();
            this.dni = "";

            for (int i = 0; i < 8; i++)
            {
                this.dni += r.Next(1, 9) + 1;
            }
            char[] letras = { 'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E' };
            int pos = Convert.ToInt32(this.dni) % 23;
            this.dni += letras[pos];
        }
    }
}
