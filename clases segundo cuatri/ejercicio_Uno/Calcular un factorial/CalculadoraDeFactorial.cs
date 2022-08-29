using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcular_un_factorial
{
    public class CalculadoraDeFactorial
    {
        public static int CalcularFactorial(int numero)
        {
            int factorial = 1;

            if (numero>0 && numero!=1)
            {
                factorial = numero * CalcularFactorial(numero-1);
            }

            return factorial;
        }
    }
}
