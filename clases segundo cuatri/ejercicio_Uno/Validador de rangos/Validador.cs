using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validador_de_rangos
{
    public class Validador
    {
        public static bool Validar(int valor, int min, int max)
        {
            bool retorno = true;

            if (max > min)
            {
                if (valor<min || valor>max)
                {
                    retorno = false;
                }

            }

            return retorno;
        }
    }
}
