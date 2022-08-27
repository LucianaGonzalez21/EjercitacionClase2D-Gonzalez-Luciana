using System;

namespace ejercicio_Uno
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int numeroIngresadoMaximo = int.MinValue;
            int numeroIngresadoMinimo = int.MaxValue;
            int acumuladorDeNumeros = 0;
            int contador = 0;

            for (int i = 0; i<5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");

                if (int.TryParse(Console.ReadLine(), out numeroIngresado))
                {
                    if (numeroIngresado > numeroIngresadoMaximo)
                    {
                        numeroIngresadoMaximo = numeroIngresado;
                    }
                    if (numeroIngresado < numeroIngresadoMinimo)
                    {
                        numeroIngresadoMinimo = numeroIngresado;
                    }
                    acumuladorDeNumeros+=numeroIngresado;
                    contador++;
                }
                else
                {
                    Console.WriteLine("Dato no valido");
                }
            }

            if (contador>0)
            {
                float promedio = acumuladorDeNumeros / contador;

                Console.WriteLine($"Numero maximo: {numeroIngresadoMaximo} Numero minimo: {numeroIngresadoMinimo} Promedio: {promedio}");

            }
            else
            {
                Console.WriteLine("Error");
            }
        }
    }
}
