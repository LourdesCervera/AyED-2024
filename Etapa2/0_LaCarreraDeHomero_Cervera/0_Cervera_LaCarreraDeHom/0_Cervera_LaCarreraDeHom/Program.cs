using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _0_Cervera_LaCarreraDeHom
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantos obstaculos quieres?");
            int numObstaculos = int.Parse(Console.ReadLine());

            int[] puntajes = new int[numObstaculos];

            for (int i = 0; i < numObstaculos; i++)
            {
                Console.WriteLine("obstaculo " + (i + 1) + " lo supera? (si/no)");
                string respuesta = Console.ReadLine();

                if (respuesta == "si")
                {
                    puntajes[i] = 10;
                }
                else if (respuesta == "no")
                {
                    puntajes[i] = +5;
                }
                else
                {
                    Console.WriteLine("Responda con si o no");
                    i--;
                }
            }

            int puntajeTotal = 0;
            for (int i = 0; i < numObstaculos; i++)
            {
                puntajeTotal += puntajes[i];
            }

            Console.WriteLine("El puntaje total es de " + puntajeTotal);
            Console.ReadKey(); 
        }
    }
}
