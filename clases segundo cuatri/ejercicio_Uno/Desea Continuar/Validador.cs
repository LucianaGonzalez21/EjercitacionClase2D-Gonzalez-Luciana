using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desea_Continuar
{
    public class Validador
    {
        public static bool ValidarRespuesta(string respuesta)
        {
            bool retorno = false;

            if (respuesta == "S" || respuesta == "s")
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
