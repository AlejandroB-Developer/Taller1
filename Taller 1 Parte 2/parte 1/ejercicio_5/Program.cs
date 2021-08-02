using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
                     
       // 5. en un almacen se hace un 20% de descuento a los clientes cuya compra
       // sea superior a 100.000. ¿Cuánto deberá pagar cada cliente?
      
       
        double compra, descuento, total;
       
        
        // se pide y lee el precio de la compra
        Console.WriteLine("Ingrese el precio de la compra");
        compra=double.Parse(Console.ReadLine());
        
       // se hace la validación con un if
       
       if(compra>100000)
       {
        descuento=compra*0.20;
        total=compra-descuento;
        Console.WriteLine("El descuento es de: "+descuento);
        Console.WriteLine("El precio a pagar es de: "+total);
       } else 
       {
         Console.WriteLine("El precio a pagar es de: "+compra);
       }
        }
    }
}
