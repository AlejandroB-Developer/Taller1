using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
       // 2. Elabore un algoritmo que lea un número y si es mayor o igual a 10 que devuelva el triple de este
        
        int numero, numerofinal;
        
        
        // se pide y lee el número
        Console.WriteLine("Ingrese el número");
        numero=int.Parse(Console.ReadLine());        
        
        
       // se hace la validación con un if
       
       if(numero>=10)
       {
        numerofinal = numero*3;
        Console.WriteLine("El número "+numero+" es mayor o igual a 10. Se devuelve: "+numerofinal);
       } else 
       {
         Console.WriteLine("el número es menor a 10");   
       }
        }
    }
}
