using System;

namespace Parte3_Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int contadorNumeros=0;
            bool numeroPrimo;
            int eleccion;
            Console.WriteLine("Que Sistema Quieres Usar?");
            Console.WriteLine("1.Saber la cantidad de numeros primos ");
            Console.WriteLine("2. Saber el salario Maximo");
            Console.WriteLine("3. Convertir un numero a letras");
            Console.WriteLine("4. Saber si una letra es consonante o vocal");
            eleccion = int.Parse(Console.ReadLine());

            if (eleccion==1)
            {
                Console.WriteLine("Introduce numero: ");
                numeroIngresado = int.Parse(Console.ReadLine());
                for (int i = 1; i <= numeroIngresado; i++)
                {

                    numeroPrimo = true;
                    int j = 2;
                    while (j <= i - 1 && numeroPrimo == true)
                    {
                        if (i % j == 0)
                            numeroPrimo = false;
                        j++;
                    }
                    if (numeroPrimo == true)
                    {
                        contadorNumeros++;
                    }
                }
                Console.WriteLine("En el rango de 1 hasta " + numeroIngresado + ", hay " + contadorNumeros + " números primos");
            }
            else if (eleccion==2)
            {
                Console.WriteLine("Sistema Sueldos");

                int sueldo = 0;
                int sueldoMaximo = 0;


                do
                {

                    Console.WriteLine("1.Introduce un sueldo  2.Introduce 0 para salir ");
                    sueldo = int.Parse(Console.ReadLine());

                    if (sueldo > sueldoMaximo)
                    {
                        sueldoMaximo = sueldo;
                    }
                } while (sueldo != 0);
                Console.WriteLine($"El sueldo maximo es: {sueldoMaximo}");

            }
            else if (eleccion==3)
            {
                int NumeroElegido, valor1, valor2, valor3;
                String Unidad1 = null;
                String Unidad3 = null;
                Console.WriteLine("Dame un numero del 1 al 99");
                NumeroElegido = int.Parse(Console.ReadLine());
                if (NumeroElegido > 0)
                {
                    if (NumeroElegido < 100)
                    {
                        if (NumeroElegido > 15)
                        {
                            valor1 = NumeroElegido % 10;
                            valor2 = NumeroElegido - valor1;
                            valor3 = valor2 / 10;
                            if (valor3 == 1)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Diez";
                                }
                                else
                                    Unidad1 = "Dieci";
                            }
                            else
                            if (valor3 == 2)
                            {
                                if (valor1 == 2)
                                {
                                    Unidad1 = "Veinte";
                                }
                                else
                                    Unidad1 = "Veinti";
                            }
                            else
                            if (valor3 == 3)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Treinta";
                                }
                                else
                                    Unidad1 = "Treinta y ";
                            }
                            else
                            if (valor3 == 4)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Cuarenta";
                                }
                                else
                                    Unidad1 = "Cuarenta y ";
                            }
                            else
                            if (valor3 == 5)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Cincuenta";

                                }
                                else
                                    Unidad1 = "Cincuenta y ";
                            }
                            else
                            if (valor3 == 6)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Sesenta";
                                }
                                else
                                    Unidad1 = "Sesenta y ";
                            }
                            else
                            if (valor3 == 7)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Setenta";
                                }
                                else
                                    Unidad1 = "Setenta y ";
                            }
                            else
                            if (valor3 == 8)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Ochenta";
                                }
                                else
                                    Unidad1 = "Ochenta y ";
                            }
                            else
                            if (valor3 == 9)
                            {
                                if (valor1 == 0)
                                {
                                    Unidad1 = "Noventa";
                                }
                                else
                                    Unidad1 = "Noventa y ";
                            }
                            if (valor1 == 9)
                            {
                                Unidad3 = "nueve";
                            }
                            else
                            if (valor1 == 8)
                            {
                                Unidad3 = "ocho";
                            }
                            else
                            if (valor1 == 7)
                            {
                                Unidad3 = "siete";
                            }
                            else
                            if (valor1 == 6)
                            {
                                Unidad3 = "seis";
                            }
                            else
                            if (valor1 == 5)
                            {
                                Unidad3 = "cinco";
                            }
                            else
                            if (valor1 == 4)
                            {
                                Unidad3 = "cuatro";
                            }
                            else
                            if (valor1 == 3)
                            {
                                Unidad3 = "tres";
                            }
                            else
                            if (valor1 == 2)
                            {
                                Unidad3 = "dos";
                            }
                            else
                            if (valor1 == 1)
                            {
                                Unidad3 = "uno";
                            }
                            Console.WriteLine($"Numero: {Unidad1} {Unidad3}");
                        }


                        else
                        if (NumeroElegido == 9)
                        {
                            Console.WriteLine("Nueve");

                        }
                        else
                        if (NumeroElegido == 8)
                        {
                            Console.WriteLine(null, "Ocho");

                        }
                        else
                        if (NumeroElegido == 7)
                        {
                            Console.WriteLine(null, "Siete");

                        }
                        if (NumeroElegido == 6)
                        {
                            Console.WriteLine(null, "Seis");

                        }
                        else
                        if (NumeroElegido == 5)
                        {
                            Console.WriteLine(null, "Cinco");

                        }
                        else
                        if (NumeroElegido == 4)
                        {
                            Console.WriteLine(null, "Cuatro");

                        }
                        if (NumeroElegido == 3)
                        {
                            Console.WriteLine(null, "Tres");

                        }
                        if (NumeroElegido == 2)
                        {
                            Console.WriteLine(null, "Dos");

                        }
                        else
                        if (NumeroElegido == 1)
                        {
                            Console.WriteLine(null, "Uno");

                        }
                        else
                        if (NumeroElegido == 10)
                        {
                            Console.WriteLine(null, "Diez");

                        }
                        else
                        if (NumeroElegido == 11)
                        {
                            Console.WriteLine(null, "Once");

                        }
                        if (NumeroElegido == 12)
                        {
                            Console.WriteLine(null, "Doce");

                        }
                        if (NumeroElegido == 13)
                        {
                            Console.WriteLine(null, "Trece");

                        }
                        if (NumeroElegido == 14)
                        {
                            Console.WriteLine(null, "Catorce");

                        }
                        if (NumeroElegido == 15)
                        {
                            Console.WriteLine(null, "Quince");

                        }
                    }
                    else
                        Console.WriteLine(null, "Tiene que ser un numero menor o igual a 99");
                }
                else
                    Console.WriteLine(null, "Tiene que ser un numero positivo");
            }
            else if (eleccion==4)
            {
                Console.WriteLine("Sistema Abecedario");

                char Letra;
                Console.WriteLine("Ingresa una letra");
                Letra = char.Parse(Console.ReadLine());
                if (Letra == 'a' || Letra == 'e' || Letra == 'i' || Letra == 'o' || Letra == 'u')
                {
                    Console.WriteLine($"La letra {Letra} es una bocal");
                }
                else
                {
                    Console.WriteLine($"La letra {Letra} es una consonante");
                }
            }

            else
            {
                Console.WriteLine("Digita un Sistema que corresponda");
            }

        }

    }
}
