using System;

class Program
{
    static void Main()
    {
        int cantidad = 5;

        string[] nombres = new string[cantidad];
        double[] calificaciones = new double[cantidad];

        // Registrar estudiantes
        for (int i = 0; i < cantidad; i++)
        {
            // Validar nombre
            for (; ; )
            {
                Console.Write("Nombre: ");
                nombres[i] = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(nombres[i]))
                    break;

                Console.WriteLine("Nombre inválido.");
            }

            // Validar nota
            for (; ; )
            {
                Console.Write("Nota (0.0 - 5.0): ");

                if (double.TryParse(Console.ReadLine(), out calificaciones[i]) &&
                    calificaciones[i] >= 0 && calificaciones[i] <= 5)
                    break;

                Console.WriteLine("Nota inválida.");
            }
        }

        double suma = 0;
        double mayor = calificaciones[0];
        double menor = calificaciones[0];
        int aprobados = 0;
        int reprobados = 0;

        // Calcular estadísticas
        for (int i = 0; i < cantidad; i++)
        {
            suma += calificaciones[i];

            if (calificaciones[i] > mayor)
                mayor = calificaciones[i];

            if (calificaciones[i] < menor)
                menor = calificaciones[i];

            if (calificaciones[i] >= 3.0)
                aprobados++;
            else
                reprobados++;
        }

        Console.WriteLine("\n===== REPORTE =====");
        Console.WriteLine("Promedio: " + (suma / cantidad).ToString("F2"));
        Console.WriteLine("Nota mayor: " + mayor.ToString("F2"));
        Console.WriteLine("Nota menor: " + menor.ToString("F2"));
        Console.WriteLine("Aprobados: " + aprobados);
        Console.WriteLine("Reprobados: " + reprobados);
    }
}
