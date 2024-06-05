using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_Cervera
{
    class Program
    {
        static void Main(string[] args)
        {
            string palabra;
            Console.WriteLine("Pon una palabra");
            
            palabra = Console.ReadLine();

            int contador;
            contador = 0;

            while (contador < 10)
            {
                Console.WriteLine(palabra);
                


                contador++;
            }
            
            Console.ReadKey();
        }
    }
}
