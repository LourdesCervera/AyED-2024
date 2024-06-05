using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_Cervera_EsMayor
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            Console.WriteLine("Ingrese su edad");
            edad = int.Parse(Console.ReadLine());
            if (edad<18)
            {
                Console.WriteLine("Es menr que 18");
            }else {
                Console.WriteLine("Es mayor que 18");
            }
            Console.ReadKey();
        }
    }
}
