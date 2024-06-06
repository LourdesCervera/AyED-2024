using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Cervera_ContratacionSof
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese la cantidad de candidatos:");
            int cantidadCandidatos = int.Parse(Console.ReadLine());

            int[] puntajes = new int[cantidadCandidatos];

            for (int i = 0; i < cantidadCandidatos; i++)
            {
                Console.WriteLine("Ingrese el puntaje del candidato " + (i + 1) + ":");
                puntajes[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidadCandidatos; i++)
            {
                for (int j = i; j < cantidadCandidatos; j++)
                {
                    if (puntajes[i] > puntajes[j])
                    {
                        int temp = puntajes[i];
                        puntajes[i] = puntajes[j];
                        puntajes[j] = temp;
                    }
                }
            }

            Console.WriteLine("Puntajes ordenados:");
            for (int i = 0; i < cantidadCandidatos; i++)
            {
                Console.Write(puntajes[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Ingrese el número para filtrar los puntajes múltiplos:");
            int numeroFiltro = int.Parse(Console.ReadLine());

            Console.WriteLine("Puntajes múltiplos de " + numeroFiltro + ":");
            for (int i = 0; i < cantidadCandidatos; i++)
            {
                if (puntajes[i] % numeroFiltro == 0)
                {
                    Console.Write(puntajes[i] + " ");
                    //es un espacio para q se vea mas estetico
                }
            }
            Console.ReadKey();
        }
    }
}