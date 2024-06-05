using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Cervera_ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;

            Console.WriteLine("Escriba un numero");
            num1 = int.Parse(Console.ReadLine());

            if (num1% 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }
            Console.ReadKey();
        }
    }
}
