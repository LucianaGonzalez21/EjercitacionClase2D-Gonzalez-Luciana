using System;

namespace Pitagoras_estaria_orgulloso
{
    class Program
    {
        static void Main(string[] args)
        {
            double baseTriangulo;
            double altura;
            double hipotenusa;

            Console.Title = "Teorema de Pitagoras";

            Console.WriteLine("Ingrese la base del triangulo: ");
            while (double.TryParse(Console.ReadLine(), out baseTriangulo) == false)
            {
                Console.WriteLine("Error. Ingrese la base del triangulo: ");
            }

            Console.WriteLine("Ingrese la altura del triangulo: ");
            while (double.TryParse(Console.ReadLine(), out altura) == false)
            {
                Console.WriteLine("Error. Ingrese la altura del triangulo: ");
            }

            hipotenusa = TeoremaPitagoras.CalcularLongitudHipotenusa(baseTriangulo, altura);
            Console.WriteLine($"Longitud de la hipotenusa: {hipotenusa:N2} cm");
        }
    }
}
