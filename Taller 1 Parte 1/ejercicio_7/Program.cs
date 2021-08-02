using System;

namespace ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {

        int  horas, minutos, segundoshoras, segundosminutos;
        
        
        // se piden las horas
        Console.WriteLine("Digite la cantidad de horas");
        horas=int.Parse(Console.ReadLine());
        
        // se piden los minutos
        Console.WriteLine("Digite la cantidad de minutos");
        minutos=int.Parse(Console.ReadLine());
        
        //se hace el cálculo de las conversiones de horas y minutos a segundos
        segundoshoras= horas*3600;
        segundosminutos=minutos*60;
      
       
        // se imprimen las conversiones
        Console.WriteLine("Las horas convertidas a segundos son: "+segundoshoras+"s");
        Console.WriteLine("Los minutos convertidos a segundos son: "+segundosminutos+"s");
        
    
        }
    }
}
