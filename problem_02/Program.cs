using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float baseNumero, exponente, resultado;

            Console.Write("Ingrese la base: ");
            baseNumero = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el exponente: ");
            exponente = float.Parse(Console.ReadLine());

            if (exponente >= 0)
            {
                resultado = 1;

                for (int i = 0; i < exponente; i++)
                {
                    resultado *= baseNumero;
                }

                Console.Write("La potencia  es: " + resultado);
            }
            else
            {
                Console.Write("El exponente debe ser mayor o igual a cero.");
            }

            Console.ReadKey();
        }
    }
    
}
