using System;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la Cantidad de Dinero que Tiene en la Cuenta: ");
            double cantidadCuenta = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite el Porcentaje de Interes que Brinda el Banco: (%)");
            float porcentajeIntereses = float.Parse(Console.ReadLine());

            double intereses = (cantidadCuenta * porcentajeIntereses) / 100;
            double dineroTotal = cantidadCuenta + intereses;

            if (intereses < 7000)
            {
                Console.WriteLine($"Puede Reinvertir, el Nuevo Total es: {dineroTotal}");
            }
            else
            {
                Console.WriteLine("La Cantidad Supera los $7,000.");
            }
        }
    }
}
