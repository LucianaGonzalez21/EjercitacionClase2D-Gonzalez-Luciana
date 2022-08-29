using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace El_tiempo_pasa
{
    public class Calculadora
    {
        public static int CalcularIntervaloDeDiasEntreFechas(DateTime fechaingresada)
        {
            DateTime fechaActual = DateTime.Now;

            int diferenciaDeDias = (int)(fechaActual - fechaingresada).TotalDays;
            //int diferencia;

            //diferencia = (int)numberOfDays;
            return diferenciaDeDias;
        }
    }
}
