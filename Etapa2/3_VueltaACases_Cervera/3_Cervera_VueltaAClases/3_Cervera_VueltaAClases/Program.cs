using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Cervera_VueltaAClases
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("¿Cuántos TPs son? ");
            int cantidadTPs = int.Parse(Console.ReadLine());

            Console.Write("Cuantos exámenes son? ");
            int cantidadExamenes = int.Parse(Console.ReadLine());

            int[] notasTPs = new int[cantidadTPs];
            int[] notasExamenes = new int[cantidadExamenes];
            
            for (int i = 0; i < cantidadTPs; i++)
            {
                Console.Write("Cual es la nota del TP nro " + (i + 1) + "? ");
                notasTPs[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < cantidadExamenes; i++)
            {
                Console.Write("Cual es la nota del examen nro " + (i + 1) + "? ");
                notasExamenes[i] = int.Parse(Console.ReadLine());
            }

            int tpsAprobados = 0;
            for (int i = 0; i < cantidadTPs; i++)
            {
                if (notasTPs[i] >= 6)
                {
                    tpsAprobados++;
                }
            }

            int porcentajeTPsAprobados = (tpsAprobados * 100) / cantidadTPs;
            int sumaExamenes = 0;
            for (int i = 0; i < cantidadExamenes; i++)
            {
                sumaExamenes += notasExamenes[i];
            }
            int promedioExamenes;
            if (cantidadExamenes == 0)
            {
                promedioExamenes = 0;
            }
            else
            {
                promedioExamenes = sumaExamenes / cantidadExamenes;
            }
            int sumaTPs = 0;
            for (int i = 0; i < cantidadTPs; i++)
            {
                sumaTPs += notasTPs[i];
            }
            int promedioTPs;
            if (cantidadTPs > 0)
            {
                promedioTPs = sumaTPs / cantidadTPs;
            }
            else
            {
                promedioTPs = 0;
            }
            int promedioTotal = (promedioExamenes + promedioTPs) / 2;

            Console.WriteLine("Promedio de examenes: " + promedioExamenes);
            Console.WriteLine("Promedio de TPs: " + promedioTPs);
            Console.WriteLine("Promedio total: " + promedioTotal);

            if (porcentajeTPsAprobados >= 75 && promedioExamenes >= 6)
            {
                Console.WriteLine("Aprobaron la materia.");
            }
            else
            {
                Console.WriteLine("No aprobaron la materia.");
            }
            Console.ReadKey();
        }
    }
}