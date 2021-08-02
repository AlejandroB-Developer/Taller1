using System;

namespace Ejercicio10_Parte2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite la Actividad a Realizar: (Dormir/Sentado)");
            String actividad = Console.ReadLine();

            Console.WriteLine("Digite el Tiempo que Dedicara a la Actividad: (Minutos)");
            float tiempoActividad = float.Parse(Console.ReadLine());

            if (actividad == "Dormir")
            {
                double cantidadCalorias = tiempoActividad * 1.08;
                Console.WriteLine($"La Cantidad de Calorias que Consumio su Cuerpo en la Actividad {actividad} en {tiempoActividad} Minutos fue de: {cantidadCalorias} Calorias.");
            }
            else if (actividad == "Sentado")
            {
                double cantidadCalorias = tiempoActividad * 1.66;
                Console.WriteLine($"La Cantidad de Calorias que Consumio su Cuerpo en la Actividad {actividad} en {tiempoActividad} Minutos fue de: {cantidadCalorias} Calorias.");
            }
            else
            {
                Console.WriteLine("La Actividad no es Válida.");
            }
        }
    }
}
