using System;

namespace ejercicio_6
{
    class Program
    {
        static void Main(string[] args)
        {
        double  precio, iva, descuento, preciodescuento, total;
        
        
        // se pide y lee el precio
        Console.WriteLine("Ingrese el monto total a pagar");
        precio=double.Parse(Console.ReadLine());
        
        // se hace el calculo del iva y del 10% de descuento
        iva = precio*0.19;
        descuento = precio*0.10;
        
        
        // se calcula el total a pagar
        preciodescuento = precio-descuento;
        total= (precio+iva)-descuento;
      
       
        // se muestra el precio, el iva, el descuento, el precio con descuento, y el precio total
        Console.WriteLine("El precio es de: "+precio);
        Console.WriteLine("El descuento es de: "+descuento);
        Console.WriteLine("El iva es de: "+iva);
        Console.WriteLine("El precio con descuento es de:"+preciodescuento);
        Console.WriteLine("El total a pagar es de: "+total);
        }
    }
}
