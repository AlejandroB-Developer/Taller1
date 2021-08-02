using System;

namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
        
        double  nota1, nota2, nota3, promedio;
        String nombre;
        
        
        // se pide y lee el nombre del estudiante
        Console.WriteLine("Ingrese el nombre del estudiante");
        nombre=Console.ReadLine();
        
        // se piden y leen las notas del estudiante
        Console.WriteLine("Ingrese la primera nota");
        nota1=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la segunda nota");
        nota2=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Ingrese la tercera nota");
        nota3=double.Parse(Console.ReadLine());
        
        // se realizan las operaciones para calcular el promedio
        promedio = (nota1+nota2+nota3)/3;
       
        
        // se muestran las notas
        Console.WriteLine("La primera nota es: "+nota1);
        Console.WriteLine("La segunda nota es: "+nota2);
        Console.WriteLine("La tercera nota es: "+nota3);
        
        // se muestra la nota final
        Console.WriteLine("La nota definitiva del alumno/a "+nombre+" es igual a: "+promedio);
        }
    }
}
