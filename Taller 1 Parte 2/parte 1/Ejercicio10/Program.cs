using System;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Usted es Mayor de Edad.");
            }
            else
            {
                Console.WriteLine("Usted es Menor de Edad.");
            }
        }
    }
}
