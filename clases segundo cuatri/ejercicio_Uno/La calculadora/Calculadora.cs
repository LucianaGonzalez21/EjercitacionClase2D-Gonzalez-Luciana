using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace La_calculadora
{
    public class Calculadora
    {
        public static float Calcular(int operandoUno, int operandoDos, string operador)
        {
            float resultado = 0;

            if (operador == "+" || operador == "-" || operador == "/" || operador == "*")
            {
                switch (operador)
                {
                    case "+":
                        resultado = operandoUno + operandoDos;
                        break;
                    case "-":
                        resultado = operandoUno - operandoDos;
                        break;
                    case "/":
                        if (Validar(operandoDos))
                        {
                            resultado = operandoUno / operandoDos;
                        }
                        break;
                    case "*":
                        resultado = operandoUno * operandoDos;
                        break;
                }
            }

            return resultado;
        }

        private static bool Validar(int divisor)
        {
            bool retorno = false;

            if (divisor != 0)
            {
                retorno = true;
            }

            return retorno;
        }
    }
}
