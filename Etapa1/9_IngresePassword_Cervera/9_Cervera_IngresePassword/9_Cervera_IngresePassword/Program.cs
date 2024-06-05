using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_Cervera_IngresePassword
{
    class Program
    {
        static void Main(string[] args)
        {
            String flor;
            String hola;

            hola = "hola";

            Console.WriteLine("Ingrese contraseña");
            flor = Console.ReadLine();
            if (hola == flor)
            {
                Console.WriteLine("Es correcto");
            }else {
                Console.WriteLine("Es incorrecto");
            }
            Console.ReadKey();
        }
    }
}
