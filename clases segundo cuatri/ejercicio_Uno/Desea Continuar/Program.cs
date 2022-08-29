using System;

namespace Desea_Continuar
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int acumulador = 0;
            string respuesta;

            do
            {
                Console.WriteLine("Ingrese un numero: ");

                while (int.TryParse(Console.ReadLine(), out numero) == false)
                {
                    Console.WriteLine("Error. Ingrese un numero: ");
                }

                acumulador += numero;

                Console.WriteLine($"Suma: {acumulador}");

                Console.WriteLine("Desea continuar? (S/N)");
                respuesta = Console.ReadLine();

            } while (Validador.ValidarRespuesta(respuesta));
        }
    }
}
