using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ4
{
    class Electrodomestico
    {
        private const char consumoDefault = 'F';
        private const string colorDefault = "Blanco";
        private double precioBase = 100;
        private string color = colorDefault;
        private char consumo = consumoDefault;
        private double peso = 5;

        public double PrecioBase { get => precioBase; set => precioBase = value; }
        public string Color { get => color; }
        public char Consumo { get => consumo; }
        public double Peso { get => peso;}

        public Electrodomestico(double precioBase, string color, char consumo, double peso)
        {
            this.precioBase = precioBase;
            
            this.peso = peso;
            ComprobarConsumoElectrico(consumo);
            ComprobarColor(color);
        }

        public Electrodomestico()
        {
        }

        public Electrodomestico(double precioBase, double peso)
        {
            this.precioBase = precioBase;
            this.peso = peso;
        }
        private void ComprobarConsumoElectrico (char letra)
        {
            if (!(letra == 'A' || letra == 'B' || letra == 'C' || letra == 'D' || letra == 'E' || letra == 'F'))
            {
                this.consumo = consumoDefault;
            }
            else
            {
                this.consumo = letra;
            }
        }
        private void ComprobarColor(String color)
        {
            if (color.ToLower() == "blanco" || color.ToLower() == "negro" || color.ToLower() == "rojo" || color.ToLower() == "azul" || color.ToLower() == "gris")
            {
                this.color = color;
            }
            else
            {
                this.color = colorDefault;
            }
        }
        public void precioFinal ()
        {
            double precioFinal = this.precioBase;
            Dictionary<char, int> consumos = new Dictionary<char, int>();
            consumos.Add('A', 100);
            consumos.Add('B', 80);
            consumos.Add('C', 60);
            consumos.Add('D', 50);
            consumos.Add('E', 30);
            consumos.Add('F', 10);

            Dictionary<int, int> pesos = new Dictionary<int, int>();
            pesos.Add(20, 10);
            pesos.Add(50, 50);
            pesos.Add(80, 80);
            pesos.Add(81, 100);

            precioFinal += consumos[this.consumo];
            foreach (KeyValuePair<int,int> k in pesos)
            {
                if (this.peso < k.Key)
                {
                    precioFinal += k.Value;
                }
                else if (k.Key == 81)
                {
                    precioFinal += k.Value;
                }
            }
            this.precioBase = precioFinal;
        }
    }
}
