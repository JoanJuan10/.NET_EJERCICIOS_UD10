using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ4
{
    class Lavadora : Electrodomestico
    {
        private const int cargaDefault = 5;
        private int carga = cargaDefault;

        public int Carga { get => carga;}

        public Lavadora(double precioBase, string color, char consumo, double peso, int carga) : base (precioBase, color, consumo, peso)        
        {
            this.carga = carga;
        }
        public Lavadora(double precioBase, double peso) : base(precioBase, peso)
        {
        }
        public Lavadora() : base()
        {

        }
        public new void precioFinal () 
        {
            base.precioFinal();
            if (this.carga > 30)
            {
                this.PrecioBase += 50;
            }
        }

    }
}
