using System;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite el Salario del Empleado: ");
            int salario = Int32.Parse(Console.ReadLine());

            if (salario > 2000000)
            {
                double retencion = (salario * 0.10);
                double total = (salario - retencion);

                Console.WriteLine($"El Salario Bruto del Empleado, es Mayor a $2,000,000. se hará una retención del 10% equivalente a: {retencion}");
            }
            else
            {
                Console.WriteLine("El Salario Bruto del Empleado es menos a $2,000,000");
            }
        }
    }
}
