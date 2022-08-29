using System;

namespace Desea_Continuar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeroIngresado;
            int acumuladorDeNumeros = 0;
            string respuestaIngresada;

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                while (int.TryParse(Console.ReadLine(), out numeroIngresado) == false)
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                }

                acumuladorDeNumeros += numeroIngresado;

                Console.WriteLine($"Suma: {acumuladorDeNumeros}");

                Console.WriteLine("Desea continuar? (S/N)");
                respuestaIngresada = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuestaIngresada));
        }
    }
}
