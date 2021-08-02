using System;

namespace Ejercicio9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite un Número: ");
            int numero = int.Parse( Console.ReadLine() );

            if (numero%5 == 0 )
            {
                Console.WriteLine("El Número es Multiplo de 5");
            }
            else
            {
                Console.WriteLine("El Número no es Multiplo de 5");
            }
        } 
    }
}
