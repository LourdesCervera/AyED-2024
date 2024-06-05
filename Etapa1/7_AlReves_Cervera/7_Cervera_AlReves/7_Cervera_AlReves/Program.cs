using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Cervera_AlReves
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            string b;
            string c;

            Console.WriteLine("Ingrese una letra");
            a = Console.ReadLine();
            Console.WriteLine("Ingrese una segunda letra");
            b = Console.ReadLine();
            Console.WriteLine("Ingrese una tercer letra");
            c = Console.ReadLine();
            Console.Write(c + b + a);
            Console.ReadKey();
        }
    }
}
