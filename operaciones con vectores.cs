using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] codigos = new int[20];

            for (int i = 0; i < codigos.Length; i++)
            {
                Console.WriteLine($"Ingrese el código {i + 1}:");
                codigos[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Ingrese el código que desea buscar:");
            int busqueda = Convert.ToInt32(Console.ReadLine());


            int indiceEcondrado = -1;

            for (int i = 0; i < codigos.Length; i++)
            {
                if (codigos[i] == busqueda)
                {
                    indiceEcondrado = i;
                    break;
                }
            }

            if (indiceEcondrado != -1)
            {
                Console.WriteLine("Ingrese el nuevo código:");
                codigos[indiceEcondrado] = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"\nVector Actualizado: {string.Join(", ", codigos)}");
            }
            else
            {
                Console.WriteLine("\nError: El código ingresado no existe en la BDD.");
            }

            Console.WriteLine($"Valor índice: {indiceEcondrado}");

            Console.ReadKey();
        }
    }
}
