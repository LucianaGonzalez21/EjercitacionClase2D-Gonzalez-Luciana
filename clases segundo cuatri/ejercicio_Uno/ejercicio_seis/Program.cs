using System;

namespace ejercicio_seis
{
    class Program
    {
        static void Main(string[] args)
        {
            int anioInicio;
            int anioFin;

            Console.Title = "Anio bisiesto";
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Ingrese un anio de inicio: ");

            if (int.TryParse(Console.ReadLine(), out anioInicio))
            {
                Console.WriteLine("Ingrese un anio de fin: ");
                if (int.TryParse(Console.ReadLine(), out anioFin))
                {
                    if (anioFin<=anioInicio)
                    {
                        Console.WriteLine("Error, el anio de fin no puede ser menor o igual al de inicio");
                    }
                    else
                    {
                        Console.WriteLine("Anios bisiestos:");
                        for (int i = anioInicio; i<=anioFin; i++)  //recorro el rango de anios ingresado
                        {
                            if ((i % 4 == 0 && i % 400 == 0 && i % 100 == 0) || (i % 4 == 0 && i %100 != 0))
                            {
                                Console.WriteLine("{0}", i);
                            }
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Eso no es un numero");
                }
            }
            else
            {
                Console.WriteLine("Eso no es un numero");
            }
        }
    }
}
