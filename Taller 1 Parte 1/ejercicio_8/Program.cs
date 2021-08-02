using System;

namespace ejercicio_8
{
    class Program
    {
        static void Main(string[] args)
        {
    
        double  inversion, monto;
        
        Console.WriteLine("Digite el precio de la inversión");
        inversion=double.Parse(Console.ReadLine());
        
        monto = inversion/0.02;
        
        Console.WriteLine("La inversión del capital es de: "+monto);
        }
    }
}
