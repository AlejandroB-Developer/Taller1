using System;

namespace Ejercicio7_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un Número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero%2 == 0)
            {
                Console.WriteLine("El Número es Par");
            }
            else
            {
                Console.WriteLine("El Número es Impar");
            }
        }
    }
}
