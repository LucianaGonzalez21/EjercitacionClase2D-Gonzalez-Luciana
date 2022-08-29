using System.Text;

namespace Aprendete_las_tablas
{
    public class TablasDeMultiplicar
    {
        public static string CalcularTabla(int numero)
        {
            StringBuilder sb = new StringBuilder();
            int resultado;

            sb.AppendFormat($"Tabla de multiplicar del {numero}:");
            sb.AppendLine();

            for (int i = 1; i<10; i++)
            {
                resultado = numero * i;
                sb.AppendFormat($"{numero} x {i} = {resultado} \n");
            }

            return sb.ToString();
        }
    }
}