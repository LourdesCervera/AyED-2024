using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Cervera_HolaNombre
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            Console.Write("Ingrese su nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
            Console.ReadKey();
        }
    }
}
