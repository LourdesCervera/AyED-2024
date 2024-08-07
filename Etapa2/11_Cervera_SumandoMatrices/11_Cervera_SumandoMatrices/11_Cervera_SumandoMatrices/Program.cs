using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cervera_SumandoMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("De cuanto es la fila para ambas matrices?");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("De cuanto es la fila para ambas matrices?");
            int m = int.Parse(Console.ReadLine());
            Console.WriteLine("Cuanto es el maximo para generar numeros randoms en la matriz?(El minimo es 1)");
            int a = int.Parse(Console.ReadLine());

            Random random = new Random();

            int[,] matrix1 = new int[n, m];
            int[,] matrix2 = new int[n, m];
            int[,] matrixR = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix1[i, j] = random.Next(1, a + 1);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix2[i, j] = random.Next(1, a + 1);
                }
            }

            Console.WriteLine("La matriz 1 generada es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix1[i, j] + "\t");
                }
                Console.WriteLine();
            }


            Console.WriteLine("La matriz 2 generada es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix2[i, j] + "\t");
                }
                Console.WriteLine();
            }


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrixR[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            Console.WriteLine("La matriz resultado es:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrixR[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}