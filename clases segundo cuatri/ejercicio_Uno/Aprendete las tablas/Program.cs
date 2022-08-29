using System;

namespace Aprendete_las_tablas
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            string tabla;

            Console.WriteLine("Ingrese un numero: ");

            if (int.TryParse(Console.ReadLine(), out numero))
            {
                tabla = TablasDeMultiplicar.CalcularTabla(numero);
                Console.WriteLine("{0}", tabla);
            }
            else
            {
                Console.WriteLine("Eso no es un numero");
            }
        }
    }
}
