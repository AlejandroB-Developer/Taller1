using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //        2.Hacer un algoritmo que calcule el total a pagar por la compra de camisas. Si se
//        compran tres camisas o más se aplica un descuento del 20% sobre el total de la
//        compra y si son menos de tres camisas un descuento del 10%

        int cantidad;
        double precio, preciocamisas, preciodescuento, descuento;
        
       
        
        // se piden y leen los datos de entrada
        Console.WriteLine("Ingrese el precio unitario de la camisa");
        precio=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la cantidad que desea comprar");
        cantidad=int.Parse(Console.ReadLine());
        
       // se hace la validación con un if
       
       if(cantidad>=3)
       {
        preciocamisas=precio*cantidad;
        descuento= preciocamisas*0.20;
        preciodescuento= preciocamisas-descuento;
        Console.WriteLine("Usted compró " +cantidad+ " camisas");
        Console.WriteLine("El precio original de cada camisa es de: $"+precio);
        Console.WriteLine("El precio total de las "+cantidad+" camisas es de : $"+preciocamisas);
        Console.WriteLine("El descuento es de: $"+descuento);
        Console.WriteLine("El precio a pagar es de: $"+preciodescuento);
       } else
       {
        preciocamisas=precio*cantidad;
        descuento= preciocamisas*0.10;
        preciodescuento= preciocamisas-descuento;
        Console.WriteLine("Usted compró " +cantidad+ " camisa(s)");
        Console.WriteLine("El precio original de cada camisa es de: $"+precio);
        Console.WriteLine("El precio total de las camisas ("+cantidad+") es de : $"+preciocamisas);
        Console.WriteLine("El descuento es de: $"+descuento);
        Console.WriteLine("El precio a pagar es de: $"+preciodescuento);
       }
        }
    }
}
