using System;

namespace Conversor_binario
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            //string numeroBinario;

            //decimal a binario
            Console.WriteLine("Ingrese un numero decimal: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero>=0)
                {
                    Console.WriteLine(Conversor.ConvertirDecimalABinario(numero));
                    //Console.WriteLine($"{numeroBinario}");
                }
                else
                {
                    Console.WriteLine("No se puede convertir a binario");
                }
            }

            //binario a decimal
            Console.WriteLine("Ingrese un numero binario: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                if (numero>=0)
                {
                    Console.WriteLine(Conversor.ConvertirBinarioADecimal(numero));
                }
                else
                {
                    Console.WriteLine("No se puede convertir a decimal");
                }
            }
        }
    }
}
