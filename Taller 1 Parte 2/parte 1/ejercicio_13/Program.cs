using System;

namespace Ejercicio_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema de Venta de computadoras");
            //Declarar Variables
            int valorCompra;
            double descuentoCompra;
            double valorIncluido;
            double valorTotal;
            //Pedir los datos
            Console.WriteLine("Hola, digite el valor de su computadora: ");
            valorCompra=  int.Parse(Console.ReadLine());

            //calculos si el valor de la compra supera el millon 
            if (valorCompra>1000000)
            {
                //Calcular valor del descuento
                descuentoCompra = valorCompra * 0.10;
                //valor incluido
                valorIncluido = (valorCompra - descuentoCompra) * 0.19;
                //valor total de la compra
                 valorTotal = (valorCompra - descuentoCompra) + valorIncluido;
                Console.WriteLine($"Tiene un descuento del 10%, Equivale a:  {descuentoCompra}");
                Console.WriteLine($"El valor Incluido de la compra es del 19%, Equivale a: {valorIncluido}");
                Console.WriteLine($"El valor total de la compra es: {valorTotal}" );
                
            }
            // Calculos si el valor de la compra NO supera el millon
            else
            {
                valorIncluido = valorCompra * 0.19;
                Console.WriteLine("no tiene derecho al descuento");
                Console.WriteLine($"El valor Incluido de la compra es del 19%, Equivale a: {valorIncluido}");
                valorTotal = valorCompra + valorIncluido;
                Console.WriteLine($"El valor total de la compra es: {valorTotal}");
            }

        }
    }
}
