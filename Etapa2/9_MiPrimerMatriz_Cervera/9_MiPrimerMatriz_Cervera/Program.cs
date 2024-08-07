using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_MiPrimerMatriz_Cervera
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el numero de filas");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el numero de columnas");
            int m = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, m];

            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j<m; j++)
                {
                    matriz[i, j] = 0;
                }
            }

            Console.WriteLine("Matriz de " + n + " x " + m + ":");
            for(int i =0; i<n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matriz[i, j] + " ");
                }
                Console.WriteLine();
            }
            
            Console.ReadKey();
        }
        
    }
}
