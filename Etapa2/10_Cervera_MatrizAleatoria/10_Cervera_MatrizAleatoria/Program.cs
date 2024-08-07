using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Ponga la cantidad de filas");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Ponga la cantidad de columnas");
        int m = int.Parse(Console.ReadLine());
        Console.WriteLine("Cuanto es el maximo para generar numeros randoms en la matriz?(El minimo es 1");
        int a = int.Parse(Console.ReadLine());

        Random random = new Random();

        int[,] matrix = new int[n, m];

        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                matrix[i, j] = random.Next(1, a + 1);
            }
        }

        Console.WriteLine("La matriz generada es:");
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < m; j++)
            {
                Console.Write(matrix[i, j] + "\t");
            }
            Console.WriteLine();
        }
        Console.ReadKey();
    }
}
