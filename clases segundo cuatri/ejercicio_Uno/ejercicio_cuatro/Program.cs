using System;

namespace ejercicio_cuatro
{
    class Program
    {
        static void Main(string[] args)
        {
            int cantidadDivisores = 0;

            for(int i=2; i<=7; i++)
            {
                for(int j=1; j<=i; j++)
                {
                    if(i % j == 0)
                    {
                        cantidadDivisores++;
                    }
                }

                if(cantidadDivisores == 2)
                {
                    double numeroPerfecto = Math.Pow(2, i - 1) * (Math.Pow(2, i)- 1);
                    Console.WriteLine(numeroPerfecto);
                }

                cantidadDivisores = 0;
            }
        }
    }
}
