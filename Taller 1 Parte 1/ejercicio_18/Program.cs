using System;

namespace ejercicio_18
{
    class Program
    {
        static void Main(string[] args)
        {
        double  preciomatricula, porcentaje1, porcentaje2, porcentaje3, porcentaje4;
        
        // se pide y lee el precio de la matrícula
        Console.WriteLine("Ingrese el precio de la matrícula");
        preciomatricula=double.Parse(Console.ReadLine());
       
        // se hacen los cálculos
        porcentaje1 = preciomatricula*0.40;
        porcentaje2 = preciomatricula*0.25;
        porcentaje3 = preciomatricula*0.20;
        porcentaje4 = preciomatricula*0.15;
       
       
        
        
        // se muestra el total de cada cuota a pagar
        Console.WriteLine("El precio total a pagar es de: "+preciomatricula);
        Console.WriteLine("El precio de la primera cuota es de: "+porcentaje1);
        Console.WriteLine("El precio de la segunda cuota es de: "+porcentaje2);
        Console.WriteLine("El precio de la tercera cuota es de: "+porcentaje3);
        Console.WriteLine("El precio de la cuarta cuota es de: "+porcentaje4);
        
        }
    }
}
