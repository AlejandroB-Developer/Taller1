using System;

namespace ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
        double  nota1, porcentaje1, nota2, porcentaje2, nota3, porcentaje3, promedio;
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

        // se calcula el porcentaje de cada nota
        porcentaje1= nota1*0.20;
        porcentaje2= nota2*0.30;
        porcentaje3= nota3*0.50;
        
        
        // se realizan las operaciones para calcular el promedio
        promedio = porcentaje1+porcentaje2+porcentaje3;
       
        
        // se muestran las notas y sus porcentajes
        Console.WriteLine("La primera nota (que equivale al 20%) es: "+nota1+" y su porcentaje es: "+porcentaje1);
        Console.WriteLine("La segunda nota (que equivale al 30%) es: "+nota2+" y su porcentaje es: "+porcentaje2);
        Console.WriteLine("La tercera nota (que equivale al 50%) es: "+nota3+" y su porcentaje es: "+porcentaje3);
        
        // se muestra la nota final
        Console.WriteLine("La nota definitiva del alumno/a "+nombre+" es igual a: "+promedio);
        }
    }
}
