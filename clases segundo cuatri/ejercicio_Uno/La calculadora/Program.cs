using System;

namespace La_calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            char salir;
            int operandoUno;
            int operandoDos;
            string operador;
            float resultado;

            do
            {
                Console.WriteLine("Ingrese el primer operando: ");
                while (int.TryParse(Console.ReadLine(), out operandoUno) == false)
                {
                    Console.WriteLine("Error. Reingrese el primer operando: ");
                }

                Console.WriteLine("Ingrese el segundo operando: ");
                while (int.TryParse(Console.ReadLine(), out operandoDos) == false)
                {
                    Console.WriteLine("Error. Reingrese el segundo operando: ");
                }

                Console.WriteLine("Ingrese la operacion que desea realizar (+, -, *, /): ");
                operador = Console.ReadLine();


                resultado = Calculadora.Calcular(operandoUno, operandoDos, operador);

                if (operador == "/" && operandoDos == 0)
                {
                    Console.WriteLine("No se puede dividir por 0");
                }
                else
                {
                    Console.WriteLine("Resultado: {0:N2}", resultado);
                }


                Console.WriteLine("Desea continuar? s/n: ");
                salir = char.Parse(Console.ReadLine());
            } while (salir == 's');

        }
    }
}
