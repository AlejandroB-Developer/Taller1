using System;

namespace ejercicio_24
{
    class Program
    {
        static void Main(string[] args)
        {
                        /**
            Un estudiante realiza un préstamo a un plazo de 5 años, donde la tasa fija de interés
            es del 5% anual, se debe solicitar el monto del préstamo y se desea calcular
            la siguiente información. 

•	   • Cuanto dinero se ha pagado de intereses en un año. 
•	   • Cuanto dinero se ha pagado de intereses en el tercer trimestre del año. 
•	   • Cuanto dinero se ha pagado de intereses en el primer mes. 
•	   • Cuanto dinero se paga en total del préstamo solicitado incluyendo intereses. 
            */
            
  
        
        double prestamo, mes, año, tercertrimestre, total, 
        // "la tasa fija de interés es del 5% anual"    
        tasa=0.05;
        
        // se solicita y lee el precio del prestamo
        Console.WriteLine("Ingrese el precio del préstamo");
        prestamo=double.Parse(Console.ReadLine());
        
        // se hacen los cálculos, teniendo en cuenta el precio del préstamo y el porcentaje de la tasa anual (5%)
        
        mes= (prestamo*tasa)/12;
        año = prestamo*tasa;
        tercertrimestre= mes*9;
        total= (tasa*5)+prestamo;
        
        // se muestran los resultados de las operaciones
        
        Console.WriteLine("El monto total del dinero que se ha pagado de intereses en un año es de: "+año);
        Console.WriteLine("El monto total del dinero que se ha pagado en el tercer trimestre del año es de: "+tercertrimestre);
        Console.WriteLine("El monto total del dinero que se ha pagado de intereses en el primer mes es de "+mes);
        Console.WriteLine("El monto total del préstamo que se paga es de "+total);
        
        }
    }
}
