using System;

namespace ejercicio_switch
{
    class Program
    {


        static void Main(string[] args)
        {

            int respuesta = 0;

            Boolean iniciar = true;

            while (iniciar)
            {
               switch (respuesta)
                {
                    case 1:
                       opcion1();
                     break;

                    case 2:
                        opcion2();
                        break;
                    case 3:
                        opcion3();
                        break;
                    case 4:
                        opcion4();
                        break;
                    case 5:
                        Console.WriteLine("Gracias por usar este programa, adiós. :^)");
                        iniciar = false;
                        break;
                }

                if (iniciar)
                {
                    Console.WriteLine("---------------------Programa de opciones-----------------------");
                    Console.WriteLine("Elija una opción: ");
                    Console.WriteLine("Opción #1: números primos ");
                    Console.WriteLine("Opción #2: sueldos");
                    Console.WriteLine("Opción #3: números en letras");
                    Console.WriteLine("Opción #4: vocales y consonantes");
                    Console.WriteLine("Opción #5: salir del programa ");
                    
                    respuesta = int.Parse(Console.ReadLine());
                }

            }
        }


    // 1.	Realizar un programa que nos pida un número n, y nos diga cuantos
    // números hay entre 1 y n que son primos.
        public static void opcion1()
        {

            int j, numero, contador=0;
            Boolean numeroprimo;
                        Console.WriteLine("------------ Opción #1: Números Primos ----------");
                        Console.WriteLine("Introduzca un número:");
                        numero = int.Parse(Console.ReadLine());
                        
                        for (int i = 2; i <=numero; i++)
                        {
                            numeroprimo = true;
                            j = 2;
                            while (j <= i - 1 && numeroprimo ==true)
                            {
                                if (i % j == 0)
                                {
                                    numeroprimo = false;
                                }
                                j++;
                            }

                            if (numeroprimo == true)
                            {
                                contador ++;
                                Console.WriteLine(i + (" es un número primo"));
                            }
                        }
                     Console.WriteLine("Entre 1 y "+numero+", hay "+contador+" número(s) primo(s)"); 
        } 
        


        // 2.	Pedir un número N, introducir N sueldos, y mostrar el sueldo máximo.
        public static void opcion2()
        {   
            int cantidadsueldos;

            Console.WriteLine("------------ Opción #2: Sueldos ----------");
            Console.WriteLine("¿Cuántos sueldos desea registrar?");
            cantidadsueldos = int.Parse(Console.ReadLine());

            int[] sueldos = new int[cantidadsueldos];

            for (int i = 0; i < cantidadsueldos; i++)
            {
                Console.WriteLine("Ingrese el precio del sueldo");
                sueldos[i] = int.Parse(Console.ReadLine());
            }

            int mayor = 0, menor = 0;
            mayor = menor = sueldos[0];

            for (int i = 0; i < sueldos.Length; i++)
            {
                if (sueldos[i] > mayor)
                {
                    mayor = sueldos[i];
                }
            }

            Console.WriteLine("El sueldo máximo es: " + mayor);
        }


        //. 3.	Pedir un número de 0 a 99 y mostrarlo escrito. Por ejemplo, para 56 mostrar: cincuenta
        // y seis. Pista: separar las unidades y las decenas. (unidades = num % 10; decenas = num / 10).
        public static void opcion3()
        {
          int num, decena, unidad;
          String u="", d="", dec="";

            Console.WriteLine("------------ Opción #3: Números a Letras ----------");
            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());

            decena = num / 10;
            unidad = (num % 10) / 1;

              switch (unidad) {
                case 1:
                    u = "uno";
                    break;
                case 2:
                    u = "dos";
                    break;
                case 3:
                    u = "tres";
                    break;
                case 4:
                    u = "cuatro";
                    break;
                case 5:
                    u = "cinco";
                    break;
                case 6:
                    u = "seis";
                    break;
                case 7:
                    u = "siete";
                    break;
                case 8:
                    u = "ocho";
                    break;
                case 9:
                    u = "nueve";
                    break;
                default:
                    break;
            }
        
        if (num==10) {
            dec = "diez";
        } else if (num==11) {
            dec = "once";
        } else if (num==12) {
            dec = "doce";
        } else if (num==13) {
            dec = "trece";
        } else if (num==14) {
            dec = "catorce";
        } else if (num==15) {
            dec = "quince";
        } else if (num==16) {
            dec = "dieciseis";
        } else if (num==17) {
            dec = "diecisiete";
        } else if (num==18) {
            dec = "dieciocho";
        } else if (num==19) {
            dec = "diecinueve";
        }
        
        switch (decena) {
            case 2:
                d = "veinte";
                break;
            case 3:
                d = "treinta";
                break;
            case 4:
                d = "cuarenta";
                break;
            case 5:
                d = "cincuenta";
                break;
            case 6:
                d = "sesenta";
                break;
            case 7:
                d = "setenta";
                break;
            case 8:
                d = "ochenta";
                break;
            case 9:
                d = "noventa";
                break;
            default:
                break;
        }
        
        if (num < 10) {
            Console.WriteLine("El numero es: " + u);
        } else if (num < 20) {
            Console.WriteLine("El numero es: " + dec);
        } else if (num < 100) {
            if (num % 10 == 0) {
                Console.WriteLine("El numero es: " + d);
            } else {
                Console.WriteLine("El numero es: "+ d + " y " + u);
            }
        }

        }



        // 4.	Pedir al usuario que ingrese una letra cualquiera del abecedario y mostrar por consola si se trata de un vocal o una consonante.
        public static void opcion4()
        {
             
            char letra;
            Console.WriteLine("------------ Opción #4: Vocales y Consonantes ----------");
            Console.WriteLine("Por favor, digite una letra:");

            letra = char.Parse(Console.ReadLine());

            switch (letra) {
                case 'a':
                case 'e':
                case 'i':
                case 'o':
                case 'u':
                    Console.WriteLine("La letra "+letra+" es una vocal");
                    break;
                case 'A':
                case 'E':
                case 'I':
                case 'O':
                case 'U':
                    Console.WriteLine("La letra "+letra+" es una vocal");
                    break;
                default:
                    Console.WriteLine("La letra "+letra+" es una consonante");
                    break;
            }
           
        }

    }
}