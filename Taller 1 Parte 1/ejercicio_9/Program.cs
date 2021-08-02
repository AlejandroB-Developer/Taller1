using System;

namespace ejercicio_9
{
    class Program
    {
        static void Main(string[] args)
        {
        double  sueldobase, venta1, venta2, venta3, comisiones, sueldototal;
       
        
        
        // se pide y lee el sueldo base, y las ventas
        Console.WriteLine("Digite su sueldo base");
        sueldobase=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el valor de su primera venta");
        venta1=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el valor de su segunda venta");
        venta2=double.Parse(Console.ReadLine());
        
        Console.WriteLine("Digite el valor de su tercera venta");
        venta3=double.Parse(Console.ReadLine());
        

        
        // se calculan las comisiones y el sueldo total
        comisiones = (venta1+venta2+venta3)*0.10;
        sueldototal = comisiones+sueldobase;
        
    
        
        // se muestra el valor de las comisiones y el sueldo total
        Console.WriteLine("Las comisiones tienen un valor de: $"+comisiones);
        Console.WriteLine("El sueldo total es de: $"+sueldototal);
        }
    }
}
