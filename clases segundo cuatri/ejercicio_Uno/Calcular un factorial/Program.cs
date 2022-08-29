using System;

namespace Calcular_un_factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int factorial;

            Console.Title = "Factorial de un numero";
            Console.WriteLine("Ingrese un numero: ");

            while (int.TryParse(Console.ReadLine(), out numeroIngresado) == false)
            {
                Console.WriteLine("Error. Ingrese un numero:");
            }

            if (numeroIngresado < 0)
            {
                Console.WriteLine("No se puede calcular el factorial de un numero negativo");
            }
            else
            {
                factorial = CalculadoraDeFactorial.CalcularFactorial(numeroIngresado);
                Console.WriteLine($"Factorial de {numeroIngresado}: {factorial}");
            }
        }
    }
}
