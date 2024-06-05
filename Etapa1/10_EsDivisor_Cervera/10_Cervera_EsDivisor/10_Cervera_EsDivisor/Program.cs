using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Cervera_EsDivisor
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;

            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            num2 = int.Parse(Console.ReadLine());

            if (num2== 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                Console.WriteLine("El resultado es " + (num1 / num2));
            }
            Console.ReadKey();
        }
    }
}
