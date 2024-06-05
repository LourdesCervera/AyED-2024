using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17_Cervera_MiPrimerMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            string menu, opcion1, opcion2, opcion3, salir, siguiente;

            Console.WriteLine("Bienvenido");
            Console.WriteLine("Siguiente");
            siguiente = Console.ReadLine();

            if (siguiente)


            Console.WriteLine("--Menu--");
            menu = Console.ReadLine();
            Console.WriteLine("Opcion 1");
            opcion1 = Console.ReadLine();
            Console.WriteLine("Opcion 2");
            opcion2 = Console.ReadLine();
            Console.WriteLine("Opcion 3");
            opcion3 = Console.ReadLine();
            Console.WriteLine("Salir");
            salir = Console.ReadLine();
            Console.ReadLine();

            Console.ReadKey();
        }
    }
}
