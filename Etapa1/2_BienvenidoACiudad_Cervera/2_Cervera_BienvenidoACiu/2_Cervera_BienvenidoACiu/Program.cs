using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cervera_BienvenidoACiu
{
    class Program
    {
        static void Main(string[] args)
        {
            String nombre;
            String ciudad;
            Console.WriteLine("Escriba un nombre ");
            nombre = Console.ReadLine();
            Console.WriteLine("Escriba una ciudad ");
            ciudad = Console.ReadLine();
            Console.WriteLine("Hola " + nombre + " Bienvenido a " + ciudad);
            Console.ReadKey();
        }
    }
}
