using System;

namespace ejercicio_cinco
{
    class Program
    {
        static void Main(string[] args)
        {

            int numero;

            Console.WriteLine("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                for (int centro = 1; centro < numero; centro++)
                {
                    int sumaAntes = 0;
                    for (int i = 0; i < centro; i++)
                    {
                        sumaAntes += i;
                    }

                    int sumaDespues = 0;
                    for (int j = centro+1; j<= sumaAntes; j++)
                    {
                        if ((sumaAntes == sumaDespues) || (sumaDespues > sumaAntes))
                        {
                            break;
                        }
                        sumaDespues += j;
                    }

                    if (sumaAntes == sumaDespues)
                    {
                        Console.WriteLine("Es un centro numerico: {0}", centro);
                    }
                }
            }
        }
    }
}
