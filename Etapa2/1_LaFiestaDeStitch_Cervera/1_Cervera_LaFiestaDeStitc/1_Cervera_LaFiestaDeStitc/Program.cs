using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Cervera_LaFiestaDeStitc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("¿Cuántos invitados hay en la fiesta?");
            int invitados = int.Parse(Console.ReadLine());

            int[] p = new int[invitados];

            for (int i = 0; i < invitados; i++)
            {
                Console.WriteLine("¿Cuánto consume el invitado " + (i + 1) + "?");
                int rc = int.Parse(Console.ReadLine());
                if (rc <= 100)
                {
                    p[i] = rc;
                }
                else
                {
                    Console.WriteLine("Ingrese un número menor a 100");
                    i--;
                }
            }

            int puntajeTotal = 0;
            for (int i = 0; i < invitados; i++)
            {
                puntajeTotal += p[i];
            }

            int promedio = puntajeTotal / invitados;
            Console.WriteLine("El promedio de consumo por invitado es: " + promedio);

            Console.ReadKey();

        }
    }
}
