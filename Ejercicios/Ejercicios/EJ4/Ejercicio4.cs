using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ4
{
    class Ejercicio4
    {
        public void Ejercicio () 
        {

            Electrodomestico[] arr1 = new Electrodomestico[10];

            int precioTelevisiones = 0;
            int precioLavadoras = 0;
            int precioTotal = 0;

            arr1[0] = new Electrodomestico(1683,164);
            arr1[1] = new Electrodomestico(1574,13);
            arr1[2] = new Electrodomestico(5681,51);
            arr1[3] = new Electrodomestico(16183, "BLANCO", 'A',62);
            arr1[4] = new Electrodomestico(728, "ROJO", 'F',12);
            arr1[5] = new Electrodomestico(1683, "AZUL", 'B',12);
            arr1[6] = new Electrodomestico(6236,342);
            arr1[7] = new Lavadora(1634, "NEGRO", 'C', 64, 20);
            arr1[8] = new Lavadora(161, "BLANCO", 'F', 100, 10);
            arr1[8] = new Lavadora(161, "BLANCO", 'F', 100, 10);
            arr1[9] = new Television(161, "BLANCO", 'F', 100, 40, true);


            for (int i = 0; i < arr1.Length; i++)
            {
                if (typeof(arr1[i]).IsInstanceOfType(Lavadora))
                {
                    precioLavadoras += arr1[i];
                }  
                else if (typeof(arr1[i]).IsInstanceOfType(Television)) 
                {
                    precioTelevisiones += arr1[i];
                }
                precioTotal += arr1[i];
            }
            Console.WriteLine("Lavadoras: {0}", precioLavadoras);
            Console.WriteLine("Televisiones: {0}", precioTelevisiones);
            Console.WriteLine("Total: {0}", precioTotal);

        }
    }
}
