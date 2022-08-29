using System;

namespace Calculadora_de_areas
{
    public class CalculadoraDeArea
    {
        public static double CalcularAreaCuadrado(double longitudLado)
        {
            double area = 0;

            if (longitudLado>0)
            {
                area = Math.Pow(longitudLado, 2);
            }

            return area;
        }

        public static double CalcularAreaTriangulo(double baseTriangulo, double altura)
        {
            double area = 0;

            if (baseTriangulo>0 && altura>0)
            {
                area = (baseTriangulo * altura)/2;
            }

            return area;
        }

        public static double CalcularAreaCirculo(double radio)
        {
            double area = 0;

            if (radio>0)
            {
                area = Math.PI * Math.Pow(radio, 2);
            }

            return area;
        }
    }
}