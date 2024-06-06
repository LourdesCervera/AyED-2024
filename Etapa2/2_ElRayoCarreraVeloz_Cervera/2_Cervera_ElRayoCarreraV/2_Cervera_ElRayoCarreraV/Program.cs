using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cervera_ElRayoCarreraV
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cuantas vueltas quieres?"); 
            int vueltas = int.Parse(Console.ReadLine());
            
            int segundos = 0;
            int[] s = new int[vueltas];
            
            for (int i = 0; i < vueltas; i++)
            {
                Console.WriteLine("¿Que tiempo en segundos tendra la vuelta Nro.: " + (i+1) + "?");
                segundos = int.Parse(Console.ReadLine().ToLower());
                s[i] = segundos;
            }

            int TiempoTotal = 0;
            int TiempoPromedio = 0;
            int TiempoMasVeloz = 0;
            int tmin=0;

            /*
                Esta parte (calcular tiempo mas veloz) la hice con un familiar...me dijo que esta un codigo para hacerlo mas rapido que es "s.Min()"
                pero que si no, se podia hacer de la siguiente manera:
            */

            for (int j=0;j<vueltas; j++)
            {
                if (j==0) {
                    tmin = s[j];
                }
                else if (tmin > s[j])
                    {
                        tmin = s[j];
                    }
                
                

                TiempoTotal = TiempoTotal + s[j];
            }

            TiempoPromedio = TiempoTotal / vueltas;
            TiempoMasVeloz = s.Min();

            Console.WriteLine("El tiempo total de la carrera fue de " + (TiempoTotal) + " segundos");
            Console.WriteLine("El promedio de las vueltas fue " + TiempoPromedio + " segundos");
            Console.WriteLine("Y el mejor tiempo fue de " + (TiempoMasVeloz) + " segundos");
     
            Console.WriteLine("Y el mejor tiempo fue de " + (tmin) + " segundos");

            Console.ReadKey();
        }
    }
}
