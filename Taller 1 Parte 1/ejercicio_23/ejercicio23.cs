using System;

namespace Ejercicio23
{
    class Program
    {
        static void Main(string[] args)
        {
            int tiempo = 5;
            double distancia = 7;
            double tiempoCalculado = (1 * 5) / 7;

            Console.WriteLine("Ingrese la Distancia que Desea Recorrer: (Km): ");
            string digito1 = Console.ReadLine();
            int distanciaUsuario = Convert.ToInt32(digito1);

            double totalCalculado = tiempoCalculado * distanciaUsuario;

            Console.WriteLine("El Escalador tardaria: " + totalCalculado + "Hrs en recorrer " + distanciaUsuario + "Km");
        }
    }
}
