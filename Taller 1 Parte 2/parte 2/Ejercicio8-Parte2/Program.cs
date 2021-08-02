using System;

namespace Ejercicio8_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite su Sexo: (F/M)");
            string sexo = Console.ReadLine();

            Console.WriteLine("Digite su Edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (sexo == "M")
            {
                float numpulsaciones = (210 - edad) / 10;
                Console.WriteLine($"El Número de Pulsaciones que debe Tener cada 10 Segundos es de: {numpulsaciones}");
            }
            else
            {
                float numpulsaciones = (220 - edad) / 10;
                Console.WriteLine($"El Número de Pulsaciones que debe Tener cada 10 Segundos es de: {numpulsaciones}");
            }
        }
    }
}
