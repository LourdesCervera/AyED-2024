using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Cervera_ZEGARPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de elementos ");
            int cantidadElementos = int.Parse(Console.ReadLine());

            int[] valores = new int[cantidadElementos];

            Console.Write("Ingrese el valor minimo para los objetos: ");
            int valorMinimo = int.Parse(Console.ReadLine());

            for (int i = 0; i < cantidadElementos; i++)
            {
                Console.Write("Ingrese el valor del objeto " + (i + 1) + ": ");
                valores[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Posiciones de los objetos cuyo valor es mayor a " + valorMinimo + ":");
            for (int i = 0; i < cantidadElementos; i++)
            {
                if (valores[i] > valorMinimo)
                {
                    Console.WriteLine("Objeto en la posición " + (i + 1) + ": " + valores[i]);
                }
            }
        }
    }
}