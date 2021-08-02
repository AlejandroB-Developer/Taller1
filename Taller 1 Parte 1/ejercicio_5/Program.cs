using System;

namespace ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
        double  km, horas, velocidad;
        
        Console.WriteLine("--------- Calcular Velocidad Final -----------");
        
        // se pide y lee la distancia recorrida
        Console.WriteLine("Ingrese la distancia recorrida (en kilómetros)");
        km=double.Parse(Console.ReadLine());
        
        // se piden y lee el tiempo recorrido
        Console.WriteLine("Ingrese el tiempo recorrido (en horas)");
        horas=double.Parse(Console.ReadLine());
        
        // se calcula la velocidad según la fórmula V=D/T
        velocidad= km/horas;
      
       
        // se muestra la velocidad calculada
        Console.WriteLine("La velocidad final es de: "+velocidad+"km/h");
        }
    }
}
