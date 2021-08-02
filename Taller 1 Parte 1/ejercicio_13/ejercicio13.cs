using System;

namespace Algoritmos_Taller1
{
    class Ejercicio13
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Número de Horas Trabajadas del Empleado: ");
            string digito1 = Console.ReadLine();
            int horasTrabajadas = Convert.ToInt32(digito1);

            Console.WriteLine("Ingrese el Valor de cada Hora: ");
            string digito2 = Console.ReadLine();
            int valorHora = Convert.ToInt32(digito2);

            double salario = (horasTrabajadas * valorHora);

            Console.WriteLine("El Salario Total del Empleado es: " + salario);
        }
    }
}