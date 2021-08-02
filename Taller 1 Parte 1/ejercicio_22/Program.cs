using System;

namespace ejercicio_22
{
    class Program
    {
        static void Main(string[] args)
        {
                        /**
             Se tienen tres baldes de agua, uno de cinco litros, otros de tres litros y
             *otro de un litro; si el de un litro tarda una hora y media en llenarse,
             *resuelva cuanto tiempo pueden tardar en llenarse los otros baldes. 
             Si tiene tres baldes, pero se desconoce su tamaño debe de resolver igualmente el ejercicio. 

            */
            
         // 1 litro = hora y media
         // hora y media = 90 minutos
            
        int eje1=5, eje2=3, eje3=1, tiempo=90, balde1, balde2, balde3, tiempo1, tiempo2, tiempo3, tiempoej1, tiempoej2, tiempoej3;
        
        // aquí se hace el cálculo pedido al principio del ejercicio
        tiempoej1 = eje1*tiempo;
        tiempoej2 = eje2*tiempo;
        tiempoej3 = eje3*tiempo;
        
        // se piden los datos de entrada para calcular el tiempo en que se demore en llenar un balde, al desconocerse
        //  su tamaño
        Console.WriteLine("Ingrese el tamaño de su primer balde en litros");
        balde1=int.Parse(Console.ReadLine());
        
         Console.WriteLine("Ingrese el tamaño de su segundo balde en litros");
        balde2=int.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese el tamaño de su primer balde en litros");
        balde3=int.Parse(Console.ReadLine());
        
        // se calcula el tiempo en que se llenen los baldes, según el tamaño ingresado
       
        tiempo1= balde1*tiempo;
        tiempo2= balde2*tiempo;
        tiempo3= balde3*tiempo;
  
        // se muestran los resultados de el problema planteado al principio
        Console.WriteLine("------------ solución #1 -------------");
        Console.WriteLine("Un balde de 5 litros se tarda en llenar: "+tiempoej1+ " minutos");
        Console.WriteLine("Un balde de 3 litros se tarda en llenar: "+tiempoej2+ " minutos");
        Console.WriteLine("Un balde de 1 litro se tarda en llenar: "+tiempoej3+ " minutos");
       
        // se muestran los resultados de cuanto tardan en llenarse los baldes a los que se les pidió su tamaño
        Console.WriteLine("");
        Console.WriteLine("------------ solución #2 -------------");
        Console.WriteLine("Un balde de "+balde1+" litro(s) se tarda en llenar: "+tiempo1+ " minutos");
        Console.WriteLine("Un balde de "+balde2+" litro(s) se tarda en llenar: "+tiempo2+ " minutos");
        Console.WriteLine("Un balde de "+balde3+" litro(s) se tarda en llenar: "+tiempo3+ " minutos");
       
        }
    }
}
