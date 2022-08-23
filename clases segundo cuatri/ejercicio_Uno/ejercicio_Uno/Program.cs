using System;

namespace ejercicio_Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int maximo = int.MinValue;
            int minimo = int.MaxValue;
            int acumulador = 0;
            int contador = 0;

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero > maximo)
                    {
                        maximo = numero;
                    }
                    if (numero < minimo)
                    {
                        minimo = numero;
                    }
                    acumulador+=numero;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Dato no valido");
                }
            }

            if (contador>0)
            {
                float promedio = acumulador / contador;

                Console.WriteLine($"Numero maximo: {maximo} Numero minimo: {minimo} Promedio: {promedio}");

            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
