using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Cervera__LaSumaAnterior
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            int num3;
            int suma;
            Console.WriteLine("ingrese un numero: ");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrese otro numero: ");
            num3 = int.Parse(Console.ReadLine());
            Console.WriteLine("suma: " + (num1 + num2 + num3));
            suma = int.Parse(Console.ReadLine());
            Console.ReadKey();

        }
    }
}
