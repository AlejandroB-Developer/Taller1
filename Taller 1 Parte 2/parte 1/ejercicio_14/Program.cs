using System;

namespace Ejercicios_14
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Variables
            int numero1, numero2;
            Console.WriteLine("Sistema suma");
            Console.WriteLine("Hola, Digite un numero: ");
            numero1 = int.Parse (Console.ReadLine());
            Console.WriteLine("Digite otro numero: ");
            numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                int suma = numero1 + numero2;
                Console.WriteLine("La suma de los dos números es: "+suma);
            }
            else{
                Console.WriteLine("El primer número es menor al segundo");
            }


        }
    }
}
