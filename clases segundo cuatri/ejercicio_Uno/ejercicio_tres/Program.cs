using System;

namespace ejercicio_tres
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int cantidadDeDivisores = 0;

            do
            {
                Console.Write("Ingrese un numero: ");

                while (int.TryParse(Console.ReadLine(), out numeroIngresado) == false)
                {
                    Console.Write("Dato no valido. Ingrese un numero: ");
                }

                Console.Write("Numeros primos: ");
                for (int i = 1; i<=numeroIngresado; i++)
                {
                    for (int j = 1; j<=i; j++)
                    {
                        if (i % j == 0)
                        {
                            cantidadDeDivisores++;
                        }
                    }

                    if (cantidadDeDivisores == 2)
                    {
                        Console.Write($" {i} ");
                    }

                    cantidadDeDivisores = 0;
                }

                Console.Write($"{Environment.NewLine}Desea continuar? si/no: ");

            } while (Console.ReadLine() == "si");
        }
    }
}
