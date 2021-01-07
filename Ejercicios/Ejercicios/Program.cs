using System;

namespace Ejercicios
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Que ejercicio quieres ejecutar?");

            Console.WriteLine("2 = Ejercicio 2");
            Console.WriteLine("3 = Ejercicio 3");
            Console.WriteLine("4 = Ejercicio 4");
            Console.WriteLine("5 = Ejercicio 5");
            Console.WriteLine("6 = Ejercicio 6");


            string ejercicio = Console.ReadLine();

            switch (ejercicio)
            {
                case "2":
                    EJ2.Ejercicio2 ej2 = new EJ2.Ejercicio2();
                    ej2.Ejercicio();
                    break;
                case "3":
                    EJ3.Ejercicio3 ej3 = new EJ3.Ejercicio3();
                    ej3.Ejercicio();
                    break;
                case "4":
                    EJ4.Ejercicio4 ej4 = new EJ4.Ejercicio4();
                    ej4.Ejercicio();
                    break;
                case "5":
                    EJ5.Ejercicio5 ej5 = new EJ5.Ejercicio5();
                    ej5.Ejercicio();
                    break;
                case "6":
                    EJ6.Ejercicio6 ej6 = new EJ6.Ejercicio6();
                    ej6.Ejercicio();
                    break;
            }
        }
    }
}
