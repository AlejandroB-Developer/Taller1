using System;

namespace Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declarar Varaibles
            float notaEstudiante1, notaEstudiante2, notaEstudiante3, notaEstudiante4,resultadoNotas;
            Console.WriteLine("Sistema Notas");
            //Pedir datos
            Console.WriteLine("Digite la nota 1: ");
            notaEstudiante1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 2: ");
            notaEstudiante2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 3: ");
            notaEstudiante3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Digite la nota 4: ");
            notaEstudiante4 = float.Parse(Console.ReadLine());

            //Operacion
            resultadoNotas = (notaEstudiante1 + notaEstudiante2 + notaEstudiante3 + notaEstudiante4) / 4;
            //Condicion
            if (resultadoNotas<3.5)
            {
                Console.WriteLine("Reprobaste :(");
            }
            else if (resultadoNotas>=3.5)
            {
                Console.WriteLine("Aprobaste :)");
            }

        }
    }
}
