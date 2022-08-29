using System;

namespace Calculadora_de_areas
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroIngresado;
            double numeroIngresadoDos;
            double areaCalculada;

            Console.WriteLine("Ingrese la longitud del lado del cuadrado: ");

            while (double.TryParse(Console.ReadLine(), out numeroIngresado) == false)
            {
                Console.WriteLine("Error. Reingrese la longitud del lado del cuadrado: ");
            }

            areaCalculada = CalculadoraDeArea.CalcularAreaCuadrado(numeroIngresado);
            Console.WriteLine($"Area del cuadrado: {areaCalculada}");

            Console.WriteLine("Ingrese la base del triangulo: ");

            while (double.TryParse(Console.ReadLine(), out numeroIngresado) == false)
            {
                Console.WriteLine("Error. Reingrese la base del triangulo: ");
            }

            Console.WriteLine("Ingrese la altura del triangulo: ");

            while (double.TryParse(Console.ReadLine(), out numeroIngresadoDos) == false)
            {
                Console.WriteLine("Error. Reingrese la altura del triangulo: ");
            }

            areaCalculada = CalculadoraDeArea.CalcularAreaTriangulo(numeroIngresado, numeroIngresadoDos);
            Console.WriteLine($"Area del triangulo: {areaCalculada}");

            Console.WriteLine("Ingrese el radio del circulo: ");

            while (double.TryParse(Console.ReadLine(), out numeroIngresado) == false)
            {
                Console.WriteLine("Error. Reingrese el radio del circulo: ");
            }

            areaCalculada = CalculadoraDeArea.CalcularAreaCirculo(numeroIngresado);
            Console.WriteLine($"Area del triangulo: {areaCalculada:N2}");
        }
    }
}
