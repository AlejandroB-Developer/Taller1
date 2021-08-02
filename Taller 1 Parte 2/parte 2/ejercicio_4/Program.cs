using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
    //     4. pedir dos números y mostrarlos ascendentemente
      
       
        int numero1, numero2;
        
       
        
        // se piden y leen los números
        Console.WriteLine("Ingrese el primer número");
        numero1=int.Parse(Console.ReadLine());
       
        Console.WriteLine("Ingrese el segundo número");
        numero2=int.Parse(Console.ReadLine());
        
       // se hace la validación con un if
       
       if(numero1<numero2)
       {
        Console.WriteLine("Los números son: "+numero1+", "+numero2);
       } else
       {
        Console.WriteLine("Los números son: "+numero2+", "+numero1);
       }
        }
    }
}
