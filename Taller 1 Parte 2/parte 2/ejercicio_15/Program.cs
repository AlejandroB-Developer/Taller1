using System;

namespace Parte2_Ejercicio15
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Almacen");

            //Declarar Variables
            int compraCliente;
            Console.WriteLine("Digite el valor de la compra: ");
            compraCliente = int.Parse(Console.ReadLine());

            //Declarar las condiciones
            if (compraCliente>200000)
            {
                double  descuentoCompra = compraCliente * 0.17;
                double valorCompra = compraCliente - descuentoCompra;
                Console.WriteLine($"El valor a pagar es: {valorCompra}");

            }
            else if (compraCliente<=200000)
            {
                double descuentoCompra = compraCliente * 0.05;
                double valorCompra = compraCliente - descuentoCompra;
                Console.WriteLine($"El valor a pagar es: {valorCompra}");

            }
        }
    }
}
