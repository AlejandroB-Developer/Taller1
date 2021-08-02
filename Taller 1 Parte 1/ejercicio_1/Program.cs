using System;



namespace ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
        int  numero1, numero2, numero3, total;
        
        Console.WriteLine("Ingrese el primer número");
        numero1= int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el segundo número");
         numero2= int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el tercer número");
         numero3= int.Parse(Console.ReadLine());
        
        total = numero1+numero2+numero3;
        
        Console.WriteLine("El primer número es: "+numero1);
        Console.WriteLine("El segundo número es: "+numero2);
        Console.WriteLine("El tercero número es: "+numero3);
        Console.WriteLine("La suma de todos los números es: "+total);
        }
    }
}