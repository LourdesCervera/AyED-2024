using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Cervera_RotarMatriz90
{
    class Program
    {
        static void Main(string[] args)
        {

            Random aleatorio = new Random();

            int n = 3;
            int[,] matriz = new int[n, n];
            int[,] resultado = new int[n, n];
            
            int i = 0;
            while (i < n)
            {
                int j = 0;
                while (j < n)
                {
                    matriz[i, j] = aleatorio.Next(1, 11);
                    j++;
                }
                i++;
            }

            i = 0;
            while (i < n)
            {
                int j = 0;
                while (j < n)
                {
                    resultado[j, n - i - 1] = matriz[i, j];
                    j++;
                }
                i++;
            }
            Console.WriteLine("Matriz original:");
            i = 0;
            while (i < n)
            {
                int j = 0;
                while (j < n)
                {
                    Console.Write(matriz[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            
            Console.WriteLine("\nMatriz rotada 90 grados en sentido horario:");
            i = 0;
            while (i < n)
            {
                int j = 0;
                while (j < n)
                {
                    Console.Write(resultado[i, j] + " ");
                    j++;
                }
                Console.WriteLine();
                i++;
            }
            Console.ReadKey();

        }
        
    }
    
}
