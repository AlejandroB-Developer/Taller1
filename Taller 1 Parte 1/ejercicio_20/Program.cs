using System;

namespace ejercicio_20
{
    class Program
    {
        static void Main(string[] args)
        {
            /**
              Ingresar el precio de compra unitario de un producto y la cantidad
            * de compra de dicho producto y un descuento. Calcular y mostrar el
            * subtotal, el monto del IVA que es el 19% del subtotal, y el precio neto
            * (precio parcial con el Monto del IVA).
            */
            
        String producto;
        int  cantidad;
        double preciounitario, subtotal, descuento, iva, total;
        
        // se piden y leen los datos de entrada
        Console.WriteLine("Ingrese el nombre del producto");
        producto=Console.ReadLine();
        
        Console.WriteLine("Ingrese el precio unitario");
        preciounitario=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la cantidad que desea comprar");
        cantidad=int.Parse(Console.ReadLine());
       
        // se hacen los cálculos. En este caso, para calcular el subtotal
        subtotal = preciounitario*cantidad;
        
        // aquí se hace un descuento del 10%
        descuento = subtotal*0.10;
        
        // iva
        iva = subtotal * 0.19;
        
        //y el total
        total = (subtotal+iva)-descuento;
  
            
        
        // se muestran los resultados
        Console.WriteLine("El producto que usted compró es: "+producto);
        Console.WriteLine("El iva es de: $"+iva);
        Console.WriteLine("El subtotal es de: $"+subtotal);
        Console.WriteLine("El descuento (10%) es de: $"+descuento);
        Console.WriteLine("El monto total a pagar es de: $"+total);
        }
    }
}
