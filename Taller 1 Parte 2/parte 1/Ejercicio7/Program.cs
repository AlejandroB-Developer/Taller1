using System;

namespace Ejercicio7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un Número: (Positivo o Negativo)");
            int numero = int.Parse( Console.ReadLine() );

            if (numero < 0)
            {
                Console.WriteLine("El Número es Negativo");
            }
            else
            {
                Console.WriteLine("El Número es Positivo");
            }
        }
    }
}
