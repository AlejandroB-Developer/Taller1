using System;

namespace Algoritmos_Taller1
{
    class Ejercicio17
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Salario del Empleado: ");
            string digito1 = Console.ReadLine();
            int salarioEmpleado = Convert.ToInt32(digito1);

            Console.WriteLine("Ingrese el Valor de Ahorro Mensual Programado: ");
            string digito2 = Console.ReadLine();
            int valorProgramada = Convert.ToInt32(digito2);

            double EPS = (salarioEmpleado * 12.5) / 100;
            double fondoPensiones = (salarioEmpleado * 0.16);
            double total = salarioEmpleado - (fondoPensiones + EPS);

            Console.WriteLine("--------COLILLA DE PAGO----------");
            Console.WriteLine("SALARIO:" + salarioEmpleado);
            Console.WriteLine("VALOR MENSUAL PROGRAMADO: " + valorProgramada);
            Console.WriteLine("DEDUCCIÓN EPS: " + EPS);
            Console.WriteLine("DEDUCCIÓN FONDO DE PENSIONES: " + fondoPensiones);
            Console.WriteLine("TOTAL: " + total);
        }
    }
}
