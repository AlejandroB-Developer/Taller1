using System;

namespace ejercicio_10
{
    class Program
    {
        static void Main(string[] args)
        {
        double  valorcompra, descuento, totalcompra;
        
        // se pide el valor de la compra
        Console.WriteLine("Digite el valor de la compra");
        valorcompra=double.Parse(Console.ReadLine());
        
        
        // se hacen las operaciones para saber de cuanto es el descuento y en cuanto queda el monto total
        descuento = valorcompra*0.15;
        totalcompra = valorcompra - descuento;
        
        Console.WriteLine("El descuento es de: "+descuento);
        Console.WriteLine("El monto total a pagar es de: "+totalcompra);
        }
    }
}
