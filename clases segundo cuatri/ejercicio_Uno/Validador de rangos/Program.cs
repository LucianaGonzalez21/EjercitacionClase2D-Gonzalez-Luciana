using System;

namespace Validador_de_rangos
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int minimo = int.MaxValue;
            int maximo = int.MinValue;
            int acumulador = 0;
            float promedio;
            int contador = 0;

            for (int i = 0; i<10; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                if (int.TryParse(Console.ReadLine(), out numero))
                {

                    if (Validador.Validar(numero, -100, 100))    //si ingreso un numero fuera de rango, este se pierde
                    {
                        if (numero < minimo)
                        {
                            minimo = numero;
                        }

                        if (numero > maximo)
                        {
                            maximo = numero;
                        }

                        acumulador += numero;
                        contador++;
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

            if (acumulador>0 && contador>0)
            {
                promedio = (float)acumulador/contador;

                Console.WriteLine("Valor minimo: {0} Valor maximo {1} Promedio: {2}", minimo, maximo, promedio);
            }
            else
            {
                Console.WriteLine("Error al realizar los calculos");
            }
        }
    }
}
