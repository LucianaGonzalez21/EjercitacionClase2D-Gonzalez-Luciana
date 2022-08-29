using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pitagoras_estaria_orgulloso
{
    public class TeoremaPitagoras
    {
        public static double CalcularLongitudHipotenusa(double baseTriangulo, double altura)
        {
            double hipotenusa = 0;

            if (baseTriangulo>0 && altura>0)
            {
                hipotenusa = Math.Sqrt((Math.Pow(baseTriangulo, 2) + Math.Pow(altura, 2)));
            }

            return hipotenusa;
        }
    }
}
