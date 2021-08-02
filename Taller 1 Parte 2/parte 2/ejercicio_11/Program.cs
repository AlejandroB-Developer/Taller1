using System;

namespace Parte2_Ejercicio_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sistema Compra de piezas");
            //Declaro Variables
            long valorCompra;
            //Pedir datos
            Console.WriteLine("Digite el valor de la compra:");
            valorCompra = long.Parse(Console.ReadLine());
            //Condicional de pagos
            if (valorCompra>=5000000)
            {
               double pagoEmpresa = valorCompra * 0.50;
               double creditoBanco = valorCompra * 0.30;
               double creditoFabricante = valorCompra * 0.15;

                Console.WriteLine($"El pago que hace la empresa es de: {pagoEmpresa},") ;
                Console.WriteLine($" el credito que hace el banco es de: {creditoBanco}");
                Console.WriteLine($"el credito que hace el fabricante es de{creditoFabricante}");
            }
            else if (valorCompra<5000000)
            {
                double pagoEmpresa = valorCompra * 0.70;
                double creditoFabricante = valorCompra * 0.30;
                double pagoIntereses = creditoFabricante * 0.15;

                Console.WriteLine($"El pago que hace la empresa es de: {pagoEmpresa}");
                Console.WriteLine($"El credito que hace el fabricante es de: {creditoFabricante}");
                Console.WriteLine($"El pago de intereses es de: {pagoIntereses}");
            }

        }
    }
}
