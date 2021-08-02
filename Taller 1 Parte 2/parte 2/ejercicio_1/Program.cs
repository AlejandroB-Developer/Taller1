using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //      1.Hacer un algoritmo que imprima el nombre de un artículo, clave, precio original
//      y su precio con descuento. El descuento lo hace en base a la clave, si la clave es
//      01 el descuento es del 10% y si la clave es 02 el descuento es del 20% (solo existen dos
//      claves).
      
    
        int clave;
        double precio, preciodescuento, descuento;
        String articulo;
       
        
        // se piden y leen los datos de entrada
        Console.WriteLine("Ingrese el nombre del artículo");
        articulo=Console.ReadLine();
        
        Console.WriteLine("Ingrese la clave del producto (01 o 02)");
        clave=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el precio del artículo");
        precio=double.Parse(Console.ReadLine());
        
       // se hace la validación con un if
       
       if(clave==01)
       {
        descuento= precio*0.10;
        preciodescuento= precio-descuento;
        Console.WriteLine("El nombre del artículo es: "+articulo);
        Console.WriteLine("La clave del artículo es: "+clave);
        Console.WriteLine("El precio original del artículo es de: $"+precio);
        Console.WriteLine("El descuento es de: $"+descuento);
        Console.WriteLine("El precio a pagar es de: $"+preciodescuento);
       } else if (clave==02)
       {
        descuento= precio*0.20;
        preciodescuento= precio-descuento;
        Console.WriteLine("El nombre del artículo es: "+articulo);
        Console.WriteLine("La clave del artículo es: "+clave);
        Console.WriteLine("El precio original del artículo es de: $"+precio);
        Console.WriteLine("El descuento es de: $"+descuento);
        Console.WriteLine("El precio a pagar es de: $"+preciodescuento);
       }
       else
       {
       Console.WriteLine("Por favor ingrese una clave válida.");
       }
        }
    }
}
