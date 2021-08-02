using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
           //     5. Determinar el precio de un pasaje de ida y vuelta por avión, conociendo
//        la distancia a recorrer y sabiendo que que esta es superior a 1.000 km, 
//        la línea aérea le hace un descuento del 30%. El precio por kilómetro es de $150.
      
        
        double preciokilometros=150,kilometrosrecorridos, calculokm, descuento, precio;
        
       
        // se piden y leen los datos de entrada
        Console.WriteLine("Ingrese la distancia total recorrida en km");
        kilometrosrecorridos=double.Parse(Console.ReadLine());
        
        calculokm=preciokilometros*kilometrosrecorridos;
        
       // se hace la validación con un if
       
       if(kilometrosrecorridos>1000)
       {
         descuento= calculokm*0.30;
         precio= calculokm-descuento;
         Console.WriteLine("La distancia recorrida es de: "+kilometrosrecorridos+"km");
         Console.WriteLine("El precio original de los ticketes es de: $"+calculokm);
         Console.WriteLine("------- tiene derecho a descuento----------");
         Console.WriteLine("El descuento es de: $"+descuento);
         Console.WriteLine("El precio total incluyendo descuento es de: $"+precio);
         
       } else
       {
         Console.WriteLine("La distancia recorrida es de: "+kilometrosrecorridos+"km");
         Console.WriteLine("El precio original de los ticketes es de: $"+calculokm);
         Console.WriteLine("El precio total es de: $"+calculokm);
         Console.WriteLine("------- no tiene derecho a descuento----------");
       }
        }
    }
}
