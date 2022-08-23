using System;

namespace ejercicio_Dos
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero;

            Console.WriteLine("Ingrese un numero:");

            if (double.TryParse(Console.ReadLine(), out numero) && numero > 0)
            {
                double cuadrado = Math.Pow(numero, 2);
                double cubo = Math.Pow(numero, 3);

                Console.WriteLine($"Numero: {numero} Cuadrado: {cuadrado} Cubo: {cubo}");

            }
            else
            {
                Console.WriteLine("Dato no valido");
            }
        }
    }
}
