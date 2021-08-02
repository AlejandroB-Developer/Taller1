using System;

namespace Ejercicio9_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la Cantidad de Horas Trabajadas: ");
            float horasTrabajadas = float.Parse(Console.ReadLine());

            if (horasTrabajadas > 40)
            {

                float horasExtras = horasTrabajadas - 40;
                double salarioBruto = 40 * 10000;
                double totalHorasExtras = horasExtras * 15000;
                double salarioNeto = salarioBruto + totalHorasExtras;

                Console.WriteLine($"El Salario Semanal del Obrero es de: {salarioNeto}");
                
            }
            else
            {

                double salarioNeto = horasTrabajadas * 10000;

                Console.WriteLine($"El Salario Semanal del Obrero es de: {salarioNeto}");

            }
        }
    }
}
