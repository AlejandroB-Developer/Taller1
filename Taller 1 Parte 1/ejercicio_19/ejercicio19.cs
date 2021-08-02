using System;

namespace Ejercicio19
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el Nombre del Estudiante: ");
            string nombreEstudiante = Console.ReadLine();

            Console.WriteLine("Ingrese el Nombre del Programa: ");
            string nombrePrograma = Console.ReadLine();

            Console.WriteLine("Ingrese el Número de Ficha: ");
            string numeroFicha = Console.ReadLine();


            Console.WriteLine("Primera Nota: ");
            string digito1 = Console.ReadLine();
            double nota1 = Convert.ToDouble(digito1);

            Console.WriteLine("Segunda Nota: ");
            string digito2 = Console.ReadLine();
            double nota2 = Convert.ToDouble(digito2);

            Console.WriteLine("Tercera Nota: ");
            string digito3 = Console.ReadLine();
            double nota3 = Convert.ToDouble(digito3);

            Console.WriteLine("Cuarta Nota: ");
            string digito4 = Console.ReadLine();
            double nota4 = Convert.ToDouble(digito4);

            Console.WriteLine("Quinta Nota: ");
            string digito5 = Console.ReadLine();
            double nota5 = Convert.ToDouble(digito5);

            double promedio = (nota1 + nota2 + nota3 + nota4 + nota5) / 5;

            Console.WriteLine("-----------PROMEDIO-----------");

            Console.WriteLine("NOMBRE: " + nombreEstudiante);

            Console.WriteLine("PROGRAMA: " + nombrePrograma);

            Console.WriteLine("FICHA: " + numeroFicha);

            Console.WriteLine("El Promedio del Estudiante es: " + promedio);

        }
    }
}
