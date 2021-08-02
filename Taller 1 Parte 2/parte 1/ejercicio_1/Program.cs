using System;

namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. leer un número e imprimir un mensaje en caso de que sea par

        int numero;
        
        
        // se pide y lee el número
        Console.WriteLine("Ingrese el número");
        numero=int.Parse(Console.ReadLine());
        
        
        
       // se hace la validación con un if
       
       if(numero%2==0)
       {
        Console.WriteLine("el número es par");
       } else 
       {
         Console.WriteLine("el número es impar");   
       }
        }
    }
}
