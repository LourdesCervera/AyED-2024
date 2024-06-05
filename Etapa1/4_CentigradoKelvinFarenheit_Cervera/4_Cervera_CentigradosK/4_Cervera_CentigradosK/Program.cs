using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Cervera_CentigradosK
{
    class Program
    {
        static void Main(string[] args)
        {
            int celsius;
            Console.WriteLine("Ponga una cantidad de grados para convertirlos");
            celsius = int.Parse(Console.ReadLine());
            Console.WriteLine("En kelvin son " + (celsius + 273));
            Console.WriteLine("y en farenheit son " + (celsius * 18 / 10 + 32));
            Console.ReadKey();
        }
    }
}
