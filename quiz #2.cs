using System;

class Program
{
    static void Main()
    {
        // Reemplazar por el número de estudiantes dado en clase
        const int NUM_ESTUDIANTES = 10;

        // Arreglos estáticos paralelos
        string[] nombres = new string[NUM_ESTUDIANTES];
        double[] calificaciones = new double[NUM_ESTUDIANTES];

        // Registro de estudiantes
        for (int i = 0; i < NUM_ESTUDIANTES; i++)
        {
            // Validar nombre
            for (bool nombreValido = false; !nombreValido;)
            {
                Console.Write($"Ingrese el nombre del estudiante {i + 1}: ");
                string nombre = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombre))
                {
                    nombres[i] = nombre;
                    nombreValido = true;
                }
                else
                {
                    Console.WriteLine("Error: el nombre no puede estar vacío.");
                }
            }

            // Validar calificación
            for (bool notaValida = false; !notaValida;)
            {
                Console.Write($"Ingrese la calificación de {nombres[i]} (0.0 - 5.0): ");
                string entrada = Console.ReadLine();

                if (double.TryParse(entrada, out double nota) &&
                    nota >= 0.0 && nota <= 5.0)
                {
                    calificaciones[i] = nota;
                    notaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: ingrese una nota numérica entre 0.0 y 5.0.");
                }
            }

            Console.WriteLine();
        }

        // Cálculo de estadísticas
        double suma = 0;
        double mayor = calificaciones[0];
        double menor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        for (int i = 0; i < NUM_ESTUDIANTES; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] > mayor)
            {
                mayor = calificaciones[i];
            }

            if (calificaciones[i] < menor)
            {
                menor = calificaciones[i];
            }

            if (calificaciones[i] >= 3.0)
            {
                aprobados++;
            }
            else
            {
                reprobados++;
            }
        }

        double promedio = suma / NUM_ESTUDIANTES;

        // Reporte final
        Console.WriteLine("=================================");
        Console.WriteLine("       REPORTE DE CALIFICACIONES");
        Console.WriteLine("=================================");

        for (int i = 0; i < NUM_ESTUDIANTES; i++)
        {
            Console.WriteLine($"{nombres[i]}: {calificaciones[i]:F2}");
        }

        Console.WriteLine("---------------------------------");
        Console.WriteLine($"Promedio: {promedio:F2}");
        Console.WriteLine($"Nota mayor: {mayor:F2}");
        Console.WriteLine($"Nota menor: {menor:F2}");
        Console.WriteLine($"Aprobados: {aprobados}");
        Console.WriteLine($"Reprobados: {reprobados}");
        Console.WriteLine("=================================");
    }
}
