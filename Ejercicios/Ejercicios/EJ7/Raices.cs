using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ7
{
    class Raices
    {
        private int a;
        private int b;
        private int c;
        private double sol1;
        private double sol2;
        private bool unicaSolucion;

        public Raices(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public void ObtenerRaices ()
        {
            Console.WriteLine("Solucion 1: {0}", this.sol1);
            Console.WriteLine("Solucion 2: {1}", this.sol2);
        }
        public void ObtenerRaiz()
        {
            if (unicaSolucion) 
            {
                Console.WriteLine("Solucion 1: {0}", this.sol1);
            }
            else
            {
                ObtenerRaices();
            }
        }
        public double getDiscriminante()
        {
            return Math.Pow(this.b, 2) - (4 * this.a * this.c);
        }
        public bool TieneRaices()
        {
            return (getDiscriminante() >= 0) ? true : false;
        }
        public bool TieneRaiz()
        {
            return (getDiscriminante() == 0) ? true : false;
        }
        public void Calcular()
        {
            if (getDiscriminante() < 0)
            {
                Console.WriteLine("No tiene solucion");
            }
            else if (getDiscriminante() == 0)
            {
                unicaSolucion = true;
                this.sol1 = (-1 * this.b) / (2 * this.a);
            }
            else
            {
                unicaSolucion = false;
                this.sol1 = ((-1 * this.b) + Math.Sqrt(getDiscriminante())) / (2 * this.a);
                this.sol2 = ((-1 * this.b) - Math.Sqrt(getDiscriminante())) / (2 * this.a);
            }
             
        }
    }
}
