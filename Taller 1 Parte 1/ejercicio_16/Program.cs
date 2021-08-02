using System;

namespace ejercicio_16
{
    class Program
    {
        static void Main(string[] args)
        {
        double  cantidadrecolectada, porcentaje;
        
        // se pide y lee cuanto dinero recolecta en un día
        Console.WriteLine("Digite la cantidad de dinero que recolecta en un día");
        cantidadrecolectada=double.Parse(Console.ReadLine());
       
        // se hacen los cálculos
        porcentaje = cantidadrecolectada*0.19;
       
       
        
        
        // se muestra el total de lo que gana el chofer en un día
        Console.WriteLine("Un día trabajando corresponde a: "+porcentaje+" pesos");
        }
    }
}
