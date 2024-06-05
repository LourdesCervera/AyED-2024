using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19_Cervera_HastaN
{
    class Program
    {
        static void Main(string[] args)
        {
            int N;
            Console.WriteLine("Ingrese un numero:");
            N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("num pares: ");

            for (int cont = 1; cont <= N; cont++)
            {
                if (cont % 2 == 0)
                {
                    Console.WriteLine(cont);
                }
            }
            Console.ReadKey();

        }
    }
}
