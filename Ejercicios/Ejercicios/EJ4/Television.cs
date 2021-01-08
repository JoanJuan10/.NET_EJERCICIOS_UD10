using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ4
{
    class Television : Electrodomestico
    {
        private int resolucion = 20;
        private bool sintonizador = false;

        public Television(int precioBase, string color, char consumo, double peso, int resolucion, bool sintonizador) : base(precioBase, color, consumo, peso)
        {
            this.resolucion = resolucion;
            this.sintonizador = sintonizador;
        }
        public Television(int precioBase, double peso) : base(precioBase, peso)
        {
        }
        public Television() : base()
        {

        }

        public new void precioFinal()
        {
            base.precioFinal();
            if (this.resolucion > 40)
            {
                this.PrecioBase += (this.PrecioBase * 30) / 100;
            }
            if (sintonizador)
            {
                this.PrecioBase += 50;
            }
        }
    }
}
