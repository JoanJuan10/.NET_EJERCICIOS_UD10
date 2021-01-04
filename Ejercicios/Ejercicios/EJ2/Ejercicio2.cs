using System;
using System.Collections.Generic;
using System.Text;

namespace Ejercicios.EJ2
{
    class Ejercicio2
    {
        public void Ejercicio ()
        {
            Console.WriteLine("Cual es tu nombre?");
            string nombre = Console.ReadLine();

            Console.WriteLine("Cual es tu edad?");
            int edad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Cual es tu sexo? (H = Hombre | M = Mujer)");
            char sexo = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("Cual es tu peso?");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Cual es tu altura?");
            double altura = Convert.ToDouble(Console.ReadLine());

            Persona p1 = new Persona();
            Persona p2 = new Persona(nombre, edad, sexo, peso, altura);
            Persona p3 = new Persona(nombre, edad, sexo);

            IMC(p1);
            IMC(p2);
            IMC(p3);

            MayorEdad(p1);
            MayorEdad(p2);
            MayorEdad(p3);

            Console.WriteLine(p1.toString());
            Console.WriteLine(p2.toString());
            Console.WriteLine(p3.toString());

        }
        public void IMC (Persona persona)
        {
            if (persona.CalcularIMC() == -1)
            {
                Console.WriteLine("Peso por debajo del ideal");
            }
            else if (persona.CalcularIMC() == 0)
            {
                Console.WriteLine("Peso ideal");
            }
            else
            {
                Console.WriteLine("Sobrepeso");
            }
        }
        public void MayorEdad(Persona persona)
        {
            if (persona.EsMayorDeEdad())
            {
                Console.WriteLine("{0}: Mayor de edad", persona.Nombre);
            }
            else
            {
                Console.WriteLine("{0}: Menor de edad", persona.Nombre);
            }
        }
    }
}
