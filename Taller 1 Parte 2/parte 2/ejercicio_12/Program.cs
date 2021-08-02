using System;

namespace Parte2_Ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Papeleria");
            //Declarar variables
            int cuadernosPapeleria;
            Console.WriteLine("Digite cuantos cuadernos desea llevar: ");
            cuadernosPapeleria = int.Parse(Console.ReadLine());
            //Condicionales
            if (cuadernosPapeleria>=5)
            {
                int valorCuadernos = 2000;
                int valorCompra = cuadernosPapeleria * valorCuadernos;
                Console.WriteLine($"El valor en total es de: {valorCompra}, cada cuaderno vale {valorCuadernos}");

            }
            else if (cuadernosPapeleria<5)
            {
                int valorCuadernos = 2500;
                int valorCompra = cuadernosPapeleria * valorCuadernos;

                Console.WriteLine($"El valor en total es de: {valorCompra}, cada cuaderno vale {valorCuadernos}");
            }

        }
    }
}
