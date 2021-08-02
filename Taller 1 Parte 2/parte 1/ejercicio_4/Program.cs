using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
       // 4. realizar un algoritmo que lea dos números e imprima la suma
       // de los dos, en caso de que el primero sea mayor que el
       // segundo
       
        
        int numero1, numero2, suma;
       
        
        // se piden y leen los números
        Console.WriteLine("Ingrese el primer número");
        numero1=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el segundo número");
        numero2=int.Parse(Console.ReadLine());
        
        
       // se hace la validación con un if
       
       if(numero1>numero2)
       {
     
        suma=numero1+numero2;
        Console.WriteLine("La suma de los dos números ingresados es igual a: "+suma);
       } else 
       {
         Console.WriteLine("El primer número es menor o igual al segundo");
       }
        }
    }
}
