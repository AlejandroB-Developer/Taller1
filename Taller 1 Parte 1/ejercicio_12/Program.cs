using System;

namespace ejercicio_12
{
    class Program
    {
        static void Main(string[] args)
        {
            double  mujeres, hombres, total,totalm, totalh;
        
        // se pide y lee cuantas mujeres y hombres hay en el grupo
        Console.WriteLine("Digite la cantidad de mujeres");
        mujeres=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite la cantidad de hombres");
        hombres=double.Parse(Console.ReadLine());
        
        // se calcula el total de personas
        total = mujeres+hombres;
        
        //se calculan los porcentajes
        totalm=(mujeres/total)*100;
        totalh=(hombres/total)*100;
        
        
        // se muestra el total de mujeres, de hombres, de personas, y el porcentaje de mujeres y hombres
        Console.WriteLine("Hay "+mujeres+" mujeres en el grupo");
        Console.WriteLine("Hay "+hombres+" hombres en el grupo");
        Console.WriteLine("Hay "+total+" personas en total");
        Console.WriteLine("El porcentaje de mujeres es de: "+totalm+"%");
        Console.WriteLine("El porcentaje de hombres es de: "+totalh+"%");
        }
    }
}
