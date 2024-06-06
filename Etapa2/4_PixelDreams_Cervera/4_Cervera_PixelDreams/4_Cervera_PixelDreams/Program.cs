using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Cervera_PixelDreams
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de participantes:");
            int cantidadParticipantes = int.Parse(Console.ReadLine());
            
            int[] puntajes = new int[cantidadParticipantes];
            
            for (int i = 0; i < cantidadParticipantes; i++)
            {
                Console.Write("Ingrese el puntaje del participante " + (i + 1) + ": ");
                puntajes[i] = int.Parse(Console.ReadLine());
            }
            
            for (int i = 0; i < cantidadParticipantes; i++)
            {
                for (int j = i ; j < cantidadParticipantes; j++)
                {
                    if (puntajes[i] < puntajes[j])
                    {
                        int temp = puntajes[i];
                        puntajes[i] = puntajes[j];
                        puntajes[j] = temp;
                    }
                }
            }
            
            for (int i = 0; i < cantidadParticipantes; i++)
            {
                Console.WriteLine("Lugar " + (i + 1) + ": " + puntajes[i] + " puntos");
            }
            
            Console.WriteLine("Primer lugar: " + puntajes[0] + " puntos");
            Console.WriteLine("Ultimo lugar: " + puntajes[cantidadParticipantes -1] + " puntos");
            //-1 pq sino, no pueden indicar bien la cantidad de participantes q son correctamente

            Console.ReadKey();
        }
    }

}