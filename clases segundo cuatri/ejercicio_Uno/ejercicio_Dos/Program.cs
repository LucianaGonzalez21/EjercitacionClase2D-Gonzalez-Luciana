using System;

namespace ejercicio_Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresado;

            Console.WriteLine("Ingrese un numero:");

            if (double.TryParse(Console.ReadLine(), out numeroIngresado) && numeroIngresado > 0)
            {
                double numeroAlCuadrado = Math.Pow(numeroIngresado, 2);
                double numeroAlCubo = Math.Pow(numeroIngresado, 3);

                Console.WriteLine($"Numero: {numeroIngresado} Cuadrado: {numeroAlCuadrado} Cubo: {numeroAlCubo}");

            }
            else
            {
                Console.WriteLine("Dato no valido");
            }
        }
    }
}
