using System;

namespace El_tiempo_pasa
{
    class Program
    {
        static void Main(string[] args)
        {
            int diferenciaDias;
            DateTime diaIngresado = Convert.ToDateTime("08/29/2021");

            diferenciaDias = Calculadora.CalcularIntervaloDeDiasEntreFechas(diaIngresado);

            Console.WriteLine($"diferencia de dias: {diferenciaDias}");
        }
    }
}
