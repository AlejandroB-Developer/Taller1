using System;

namespace ejercicio_15
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Digite un numero: ");
            numero= int.Parse(Console.ReadLine());
            double cuboNumero;
            if (numero>=10)
            {
                cuboNumero = Math.Pow(numero, 3);
                Console.WriteLine($" el cubo de {numero} es {cuboNumero}");
            }
            else
            {
                Console.WriteLine("no se puede sacar el cubo");
            }

        }
    }
}
