using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
//    3.Elabore un algoritmo que lea un número y si este es mayor o igual a 10
//    devuelva el triple de este de lo contrario la cuarta parte de este.
      
       
        double numero, multiplicacion, division;
        
       
        
        // se pide y lee el número
       Console.WriteLine("Ingrese un número");
       numero=double.Parse(Console.ReadLine());
       
        
       // se hace la validación con un if
       
       if(numero>=10)
       {
        multiplicacion=numero*3;
       Console.WriteLine("El número es mayor o igual a 10. Se devuelve: "+multiplicacion);
       } else
       {
        division=numero/4;
       Console.WriteLine("El número es menor a 10. Se devuelve: "+division);
       }
        }
    }
}
