using System;

namespace ejercicio_14
{
    class Program
    {
        static void Main(string[] args)
        {
        String  articulo1, articulo2, articulo3, articulo4;
        int cant1, cant2, cant3, cant4;
        double totalproductos, precio, iva, montototal, precio1, precio2, precio3, precio4;
        
        // se pide y leen los articulos deseados, y la cantidad que se desea comprar de cada uno
        Console.WriteLine("Digite el primer artículo que desea comprar");
        articulo1=Console.ReadLine();
        Console.WriteLine("Digite el precio de ese artículo");
        precio1=double.Parse(Console.ReadLine());
        Console.WriteLine("¿Cuántas unidades de "+articulo1+" desea llevar?");
        cant1=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el segundo artículo que desea comprar");
        articulo2=Console.ReadLine();
        Console.WriteLine("Digite el precio de ese artículo");
        precio2=double.Parse(Console.ReadLine());
         Console.WriteLine("¿Cuántas unidades de "+articulo2+" desea llevar?");
        cant2=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el tercer artículo que desea comprar");
        articulo3=Console.ReadLine();
        Console.WriteLine("Digite el precio de ese artículo");
        precio3=double.Parse(Console.ReadLine());
        Console.WriteLine("¿Cuántas unidades de "+articulo3+" desea llevar?");
        cant3=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el cuarto artículo que desea comprar");
        articulo4=Console.ReadLine();
        Console.WriteLine("Digite el precio de ese artículo");
        precio4=double.Parse(Console.ReadLine());
        Console.WriteLine("¿Cuántas unidades de "+articulo4+" desea llevar?");
        cant4=int.Parse(Console.ReadLine());
        
        // se hacen los calculos
        totalproductos = cant1 + cant2  + cant3 + cant4;
        precio = (cant1*precio1) + (cant2*precio2)  + (cant3*precio3) + (cant4*precio4);
        iva = precio*0.19;
        montototal = precio+iva;
       
        
        // se muestra el total de productos, el total, y el total con iva
        Console.WriteLine("El total de productos que hay es de "+totalproductos+" productos");
        Console.WriteLine("El Precio a pagar es de "+precio);
        Console.WriteLine("El iva es de "+iva);
        Console.WriteLine("El monto total a pagar es de "+montototal);
        }
    }
}
