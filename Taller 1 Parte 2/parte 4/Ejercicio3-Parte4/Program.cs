using System;

namespace Ejercicio3_Parte4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un Número entre 0 y 99");
            int numero = int.Parse(Console.ReadLine());

            if(numero >= 0 && numero < 16)
            {
                Console.WriteLine(ObtenerUnidades(numero));
            }
            else if(numero >= 0 && numero < 100)
            {
                int decenas = numero / 10;
                int unidades = numero % 10;
                Console.WriteLine(ObtenerDecenas(decenas) + " Y " + ObtenerUnidades(unidades));
            }
        }

        static string ObtenerDecenas(int num)
        {
            string numero = "";

            switch (num)
            {
                case 2:
                    numero = "VEINTI";
                    break;
                case 3:
                    numero = "TREINTA";
                    break;
                case 4:
                    numero = "CUARENTA";
                    break;
                case 5:
                    numero = "CINCUENTA";
                    break;
                case 6:
                    numero = "SESENTA";
                    break;
                case 7:
                    numero = "TETENTA";
                    break;
                case 8:
                    numero = "OCHENTA";
                    break;
                case 9:
                    numero = "NOVENTA";
                    break;
            }

            return numero;
        }

        static string ObtenerUnidades(int num)
        {
            string numero = "";

            switch (num)
            {
                case 0:
                    numero = "CERO";
                    break;
                case 1:
                    numero = "UNO";
                    break;
                case 2:
                    numero = "DOS";
                    break;
                case 3:
                    numero = "TRES";
                    break;
                case 4:
                    numero = "CUATRO";
                    break;
                case 5:
                    numero = "CINCO";
                    break;
                case 6:
                    numero = "SEIS";
                    break;
                case 7:
                    numero = "SIETE";
                    break;
                case 8:
                    numero = "OCHO";
                    break;
                case 9:
                    numero = "NUEVE";
                    break;
                case 10:
                    numero = "DIEZ";
                    break;
                case 11:
                    numero = "ONCE";
                    break;
                case 12:
                    numero = "DOCE";
                    break;
                case 13:
                    numero = "TRECE";
                    break;
                case 14:
                    numero = "CATORCE";
                    break;
                case 15:
                    numero = "QUINCE";
                    break;
            }

            return numero;
        }
    }
}
