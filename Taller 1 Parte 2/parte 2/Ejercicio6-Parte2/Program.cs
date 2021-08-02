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
                double retencionMayor = (salario * 0.10);
                double totalMayor = (salario - retencionMayor);

                Console.WriteLine($"El Salario Bruto del Empleado, es Mayor a $2,000,000. Se le hará una retención del 10% equivalente a: {retencionMayor}");
            }
            else
            {
                double retencionMenor = (salario * 0.03);
                double totalMenor = (salario - retencionMenor);

                Console.WriteLine($"El Salario Bruto del Empleado es menor a $2,000,000. Se le hará una retención del 3% equivalente a: {retencionMenor}");
            }
        }
    }
}