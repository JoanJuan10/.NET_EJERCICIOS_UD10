using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ1
{
    class Cuenta
    {
        private string titular;
        private double cantidad;

        public Cuenta(string titular)
        {
            this.titular = titular;
            this.cantidad = 0;
        }

        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }

        public string Titular { get => titular; set => titular = value; }
        public double Cantidad { get => cantidad; set => cantidad = value; }

        public string toString ()
        {
            return "Titular: " + this.titular + " - Cantidad: " + this.cantidad;
        }
        public void Ingresar (double cantidad)
        {
            if (cantidad > 0)
            {
                this.cantidad += cantidad;
            }
        }
        public void Retirar(double cantidad)
        {
            if (this.cantidad - cantidad < 0)
            {
                this.cantidad = 0;
            }
            else
            {
                this.cantidad -= cantidad;
            }
        }


    }
}
