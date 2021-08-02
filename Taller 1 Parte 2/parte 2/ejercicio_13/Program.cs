using System;

namespace Parte2_Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {

             //declarar variables
            int salarioComprador, valorVivienda;
            //pedir datos
            Console.WriteLine("Sistema de viviendas");
            Console.WriteLine("Digite sus ingresos mensuales: ");
            salarioComprador = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite el valor de la vivienda: ");
            valorVivienda = int.Parse(Console.ReadLine());

            //Condicionales
            if (salarioComprador>=1200000)
            {
                double cuotaInicial = valorVivienda * 0.15;
                double cuotasGenerales = (valorVivienda * 0.85) / 120;
                double interesesMensuales = cuotasGenerales * 0.02;
                double cuotasValor = cuotasGenerales + interesesMensuales;
                Console.WriteLine($"el valor de la primera cuota es de: {cuotaInicial}");
                Console.WriteLine($"el valor de las cuotas es de: {cuotasGenerales}");

            }
            else if (salarioComprador<1200000)
            {
                double cuotaInicial = valorVivienda * 0.30;
                double cuotasGenerales = (valorVivienda * 0.70) / 84;
                double interesesMensuales = cuotasGenerales * 0.01;
                double cuotasValor = cuotasGenerales + interesesMensuales;
                Console.WriteLine($"el valor de la primera cuota es de: {cuotaInicial}");
                Console.WriteLine($"el valor de las cuotas es de: {cuotasGenerales}");
            }
            Console.ReadKey();
        }
        
    }
}
