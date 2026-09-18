using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] numeros = new int[5]
                { 25, 50 , 100, 200, 400 };
            Console.WriteLine($"Elementos en [0]: {numeros[0]}");

            string[] estudiantes =
                { "juan","fernando","rocha","berdugo"};

            for (int i = 0; i < estudiantes.Length; i++)
            {
                Console.WriteLine($"indice [{i}]:{estudiantes[i]}");
            }
            //una tienda registra las ventas de 10 dias en un array double[]
            //calcular
            //1.calcular total vendido
            //2.promedio diario
            //3.encontrar dia con mayor venta
            //4.dia con menor venta
            //5.contar cuantos dias superaron el promediop

            double[] ventas = { 200.000, 302, 500, 250, 350, 600, 700, 800, 900 };
            double total = 0;
            double mayorventa = ventas[0];
            double menorventa = ventas[0];
            int diamayorventa = 0;
            int diamenorventa = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                total += ventas[i];

                //i = 0
                //ventas[i] =302.000
                //total = 502.000

                if (ventas[i] > mayorventa)
                {
                    mayorventa += ventas[i];
                    diamayorventa = i;
                }
                if (ventas[i] > menorventa)
                {
                    menorventa = ventas[i];
                    diamenorventa = i;
                }

            }

            double promedio = total / ventas.Length;
            int diassobrepromedio = 0;

            for (int i = 0; i < ventas.Length; i++)
            {
                if (ventas[i] > promedio)
                {
                    diassobrepromedio++;
                }
            }
            Console.WriteLine("REPORTE MAYOR DE VENTAS");
            Console.WriteLine();

            Console.WriteLine($"total vendido: ${total}");
            Console.WriteLine($"promedio diario: ${promedio}");
            Console.WriteLine();

            Console.WriteLine($"mayor venta: ${mayorventa} - el dia {diamayorventa + 1}");
            Console.WriteLine($"menor venta: ${menorventa} - el dia {diamenorventa + 1}");

            Console.WriteLine($"dias que se supero el promedio de ventas: ${diassobrepromedio}");
            Console.WriteLine();

            Console.WriteLine("ventas por dias");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"dia {i + 1}: ${ventas[i]:F3}");

            }
        }
    }
}

