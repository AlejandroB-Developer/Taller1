using System;

namespace Ejercicio21
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioActual = 2021;

            Console.WriteLine("Ingrese el Nombre del Aprendiz: ");
            string nombreAprendiz = Console.ReadLine();

            Console.WriteLine("Ingrese la Dirección del Aprendiz: ");
            string direccionAprendiz = Console.ReadLine();

            Console.WriteLine("Ingrese el Año de Nacimiento del Aprendiz: ");
            string digito1 = Console.ReadLine();
            int anioNacimiento = Convert.ToInt32(digito1);

            int edadAprendiz = (anioActual - anioNacimiento);

            Console.WriteLine("--------APRENDIZ---------");
            Console.WriteLine("NOMBRE: " + nombreAprendiz);
            Console.WriteLine("DIRECCIÓN: " + direccionAprendiz);
            Console.WriteLine("AÑO NACIMIENTO: " + anioNacimiento);
            Console.WriteLine("EDAD: " + edadAprendiz);
        }
    }
}
