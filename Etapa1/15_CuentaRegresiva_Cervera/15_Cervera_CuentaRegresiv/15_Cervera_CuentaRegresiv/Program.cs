using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15_Cervera_CuentaRegresiv
{
    class Program
    {
        static void Main(string[] args)
        {
            int cuenta;
            int contador;
            contador = 0;
            Console.WriteLine("Pon un numero");
            cuenta = int.Parse(Console.ReadLine());

            while (contador < cuenta)
            {
                Console.WriteLine(cuenta - contador);
                contador++;


            }
            Console.ReadKey();
        }
    }
}
