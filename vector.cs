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
        }
    }
}
