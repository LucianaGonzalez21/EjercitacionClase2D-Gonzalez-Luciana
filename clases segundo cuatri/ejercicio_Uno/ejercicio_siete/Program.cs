using System;

namespace ejercicio_siete
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Recibo de sueldo";

            float valorHora;
            string nombre;
            int antiguedad;
            int cantidadHoras;
            double importe;
            double importeTotal;
            string salir;

            do
            {
                Console.WriteLine("Ingrese el valor de la hora: ");

                if (float.TryParse(Console.ReadLine(), out valorHora))
                {
                    if (valorHora<=0)
                    {
                        Console.WriteLine("El valor tiene que ser un numero positivo");
                    }
                    else
                    {
                        Console.WriteLine("Ingrese el nombre del empleado: ");
                        nombre = Console.ReadLine();

                        Console.WriteLine("Ingrese los anios de antiguedad: ");

                        if (int.TryParse(Console.ReadLine(), out antiguedad))
                        {
                            if (antiguedad<=0)
                            {
                                Console.WriteLine("Antiguedad no valida");
                            }
                            else
                            {
                                Console.WriteLine("Ingrese la cantidad de horas trabajadas: ");
                                if (int.TryParse(Console.ReadLine(), out cantidadHoras))
                                {
                                    if (cantidadHoras<=0)
                                    {
                                        Console.WriteLine("La cantidad de horas debe ser un numero positivo");
                                    }
                                    else
                                    {
                                        //hago los calculos
                                        importe = ((double)valorHora * cantidadHoras) + (antiguedad * 150);
                                        importeTotal = importe - (importe * 0.13);

                                        Console.WriteLine("Nombre: {0} Antiguedad: {1} Valor Por Hora: {2} Total en Bruto: {3} Total en Neto: {4}", nombre, antiguedad, valorHora, importe, importeTotal);

                                    }
                                }
                                else
                                {
                                    Console.WriteLine("Eso no es un numero");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("Eso no es un numero");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Eso no es un numero");
                }

                Console.WriteLine("Desea ingresar otro empleado? si/no : ");
                salir = Console.ReadLine();
            } while (salir == "si");
        }
    }
}
