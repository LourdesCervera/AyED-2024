using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cervera_DimensionesDeE
{
    class Program
    {
        static void Main(string[] args)
        {
            int radio;
            Console.WriteLine("Escriba un radio ");
            radio = int.Parse(Console.ReadLine());
            Console.WriteLine("La superficie es " + 4 * 3.14 * +(radio * radio));
            Console.WriteLine("y el volumen es " + (4 * 3.14) / 3 * (radio * radio * radio));
            Console.ReadKey();
        }
    }
}
