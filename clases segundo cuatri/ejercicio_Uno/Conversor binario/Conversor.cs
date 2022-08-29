using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversor_binario
{
    public class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero)
        {
            string valorBinario = string.Empty;
            int resultadoDivision = numeroEntero;
            int restoDivision;

            if(resultadoDivision >= 0)
            {
                do
                {
                    restoDivision = resultadoDivision % 2;
                    resultadoDivision /= 2;
                    valorBinario = restoDivision.ToString() + valorBinario; //asi queda la ultima division en primer posicion
                } while (resultadoDivision > 0);
            }
            return valorBinario;
        }

        public static string InvertirCadena(string cadena)
        {
            string cadenaInvertida = "";
            // Recorrer cadena letra por letra
            foreach (char letra in cadena)
            {
                // Anteponer la letra a la cadena invertida
                cadenaInvertida = letra + cadenaInvertida;
            }
            return cadenaInvertida;
        }


        public static int ConvertirBinarioADecimal(int numeroEntero)
        {
            int retorno = 0;
            string stringRecibida = string.Empty + numeroEntero;    //convertir int a string
            int tam;

            tam = stringRecibida.Length;

            foreach (char caracter in stringRecibida)
            {
                tam--;
                if (caracter == '1')
                {
                    retorno += (int)Math.Pow(2, tam);
                }
            }

            return retorno;
        }
    }
}
