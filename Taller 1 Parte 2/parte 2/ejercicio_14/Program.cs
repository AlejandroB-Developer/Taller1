using System;

namespace Parte2_Ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema cubo y triple");

            int numero;
            Console.WriteLine("Digite un numero: ");
            numero = int.Parse(Console.ReadLine());
            int numeroPar = numero % 2;

            if (numeroPar==0)
            {
                double cuboNumero= Math.Pow(numero, 3);
                Console.WriteLine($"El cubo es: {cuboNumero}");

            }
            else if (numeroPar!=0)
            {
                numero = numero * 3;
                Console.WriteLine($"El triple es: {numero}");
            }

            
        }
    }
}
