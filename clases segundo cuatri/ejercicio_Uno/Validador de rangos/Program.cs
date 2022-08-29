using System;

namespace Validador_de_rangos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroMinimo = int.MaxValue;
            int numeroMaximo = int.MinValue;
            int acumuladorNumeros = 0;
            float promedioDeNumeros;
            int cantidadDeNumeros = 0;

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {

                    if (Validador.Validar(numeroIngresado, -100, 100))    //si ingreso un numero fuera de rango, este se pierde
                    {
                        if (numeroIngresado < numeroMinimo)
                        {
                            numeroMinimo = numeroIngresado;
                        }

                        if (numeroIngresado > numeroMaximo)
                        {
                            numeroMaximo = numeroIngresado;
                        }

                        acumuladorNumeros += numeroIngresado;
                        cantidadDeNumeros++;
                    }
                    else
                    {
                        Console.WriteLine("numero fuera de rango");
                        continue;
                    }
                }
                else
                {
                    Console.WriteLine("Eso no es un numero");
                }
            }

            if (acumuladorNumeros>0 && cantidadDeNumeros>0)
            {
                promedioDeNumeros = (float)acumuladorNumeros/cantidadDeNumeros;

                Console.WriteLine("Valor minimo: {0} Valor maximo {1} Promedio: {2}", numeroMinimo, numeroMaximo, promedioDeNumeros);
            }
            else
            {
                Console.WriteLine("Error al realizar los calculos");
            }
        }
    }
}
