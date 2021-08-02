using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
             // 3. Un proveedor de computadores ofrece descuento del 10%, si cuesta $1.000.000
       // o más. Determinar cuánto pagará, con IVA incluído (19%), un cliente si la 
       // compra cumple con esta condición
       
        double precio, preciototal, iva, descuento;
       
        
        // se pide y lee el número
        Console.WriteLine("Ingrese el precio del computador");
        precio=double.Parse(Console.ReadLine());
        
        
        // se calcula el valor del iva y el porcentaje, según el precio ingresado
        iva = precio*0.19;
        descuento = precio*0.10;
       
        
       // se hace la validación con un if
       
       if(precio>=1000000)
       {
     
        preciototal= precio+(iva)-(descuento);
        Console.WriteLine("El precio a pagar es de: "+preciototal);
        Console.WriteLine("El iva es de: "+iva);
        Console.WriteLine("El descuento es de: "+descuento);
       } else 
       {
         preciototal= precio+iva;
         Console.WriteLine("El precio a pagar es de: "+preciototal);
         Console.WriteLine("El iva es de: "+iva);
         
       }
        }
    }
}
