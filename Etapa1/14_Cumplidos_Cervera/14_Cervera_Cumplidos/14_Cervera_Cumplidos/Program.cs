using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Cervera_Cumplidos
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int contador;
            contador = 0;
            Console.WriteLine("Pon tu edad");
            edad = int.Parse(Console.ReadLine());

            while (contador < edad)
            {
                Console.WriteLine(contador + 1);
                contador++;


            }
            Console.ReadKey();
        }
    }
}
