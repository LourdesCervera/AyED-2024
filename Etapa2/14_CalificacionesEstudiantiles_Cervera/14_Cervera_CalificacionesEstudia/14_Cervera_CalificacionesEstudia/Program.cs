using System;

class Program
{
    static void Main()
    {
        int n = 3;
        string[,] estudiantes = new string[n, 3];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1) + ":");

            Console.Write("Nombre: ");
            estudiantes[i, 0] = Console.ReadLine();

            Console.Write("Edad: ");
            estudiantes[i, 1] = Console.ReadLine();

            Console.Write("Calificación: ");
            estudiantes[i, 2] = Console.ReadLine();
        }

        Console.WriteLine("Datos de los estudiantes:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Estudiante " + (i + 1) + ": Nombre: " + estudiantes[i, 0] + ", Edad: " + estudiantes[i, 1] + ", Calificación: " + estudiantes[i, 2]);
        }
        Console.ReadKey();
    }
}
