using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _18_Cervera_HastaQueSi
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;
            string si = "SI";

            while (continuar)
            {
                Console.WriteLine("Diga 'SI' para terminar:");
                string respuesta = Console.ReadLine();

                if (respuesta == si)
                {
                    continuar = false;
                    Console.WriteLine("¡Hasta luego!");
                }
                else
                {
                    Console.WriteLine("No ha ingresado 'SI', por favor intente de nuevo.");
                }
            }

            Console.ReadKey();
        }
    }
}
