using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_Cervera_CobrarBeca
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad;
            int ingresos;

            Console.WriteLine("Cuantos años tienes?");
            edad = int.Parse(Console.ReadLine());
            Console.WriteLine("Cual es tu ingreso mensual?");
            ingresos = int.Parse(Console.ReadLine());

            if (edad == 19)
            {
                if (ingresos >= 100000)
                {
                    Console.WriteLine("Puedes tener la beca");
                }
                else
                {
                    Console.WriteLine("No puedes tener la beca");
                }
            }
            else

            {
                Console.WriteLine("Puedes tener tu beca");
            }
            else
                {
                    Console.WriteLine("No puedes tener tu beca");
                }
            }
            Console.ReadKey();
            }
        }
}