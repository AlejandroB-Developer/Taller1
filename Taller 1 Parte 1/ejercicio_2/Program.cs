using System;

namespace ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {

        double  numero1, numero2, numero3, totalsuma, totalresta, totalmult, totaldiv;
        
        
        // se piden y leen los números
        Console.WriteLine("Ingrese el primer número");
        numero1=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el segundo número");
        numero2=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el tercer número");
        numero3=double.Parse(Console.ReadLine());
        
        // se realizan las operaciones con los números ingresados
        totalsuma = numero1+numero2+numero3;
        totalresta = numero1-numero2-numero3;
        totalmult = numero1*numero2*numero3;
        totaldiv = numero1/numero2/numero3;
        
        // se muestran los números
        Console.WriteLine("El primer número es: "+numero1);
        Console.WriteLine("El segundo número es: "+numero2);
        Console.WriteLine("El tercero número es: "+numero3);
        
        // se muestran las operaciones
        Console.WriteLine("La suma de todos los números es: "+totalsuma);
        Console.WriteLine("La resta de todos los números es: "+totalresta);
        Console.WriteLine("La multiplicación de todos los números es: "+totalmult);
        Console.WriteLine("La división de todos los números es: "+totaldiv);
    
        }
    }
}
