using System;

namespace Ejercicio4_Parte4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese Cualquier Letra del Abecedario: ");
            String letra = Console.ReadLine();

            switch (letra.ToLower())
            {
                case "a":
                case "e":
                case "i":
                case "o":
                case "u":
                    Console.WriteLine("La Letra que Ingreso es una Vocal.");
                    break;
                default:
                    Console.WriteLine("La Letra que Ingreso es una Consonante.");
                    break;
            }
        }
    }
}
