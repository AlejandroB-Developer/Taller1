using System;

namespace Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Alturas");

            float alturaPersona;
            Console.WriteLine("Digite su estatura: ");
            alturaPersona = float.Parse(Console.ReadLine());

            if (alturaPersona>1.70)
            {
                Console.WriteLine("Eres alto");
            }
            else
            {
                Console.WriteLine("No eres alto");
            }
        }
    }
}
