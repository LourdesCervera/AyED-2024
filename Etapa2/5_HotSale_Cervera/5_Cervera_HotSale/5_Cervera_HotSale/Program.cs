using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Cervera_HotSale
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese la cantidad de productos vendidos ");
            int cantidadProductos = int.Parse(Console.ReadLine());

            int precioMasAlto = int.MinValue;
            int precioMasBajo = int.MaxValue;

            for (int i = 0; i < cantidadProductos; i++)
            {
                Console.Write("Ingrese el precio del producto " + (i + 1) + ": ");
                int precioProducto = int.Parse(Console.ReadLine());

                if (precioProducto > precioMasAlto)
                    precioMasAlto = precioProducto;
                //esto es como un bucle, si precioProducto es mayor a precioAlto, entonces se guarda el valor y se "actualiza" y sigue comparando si hay otro precio mas alto

                if (precioProducto < precioMasBajo)
                    precioMasBajo = precioProducto;
            }

            Console.WriteLine("El precio mas alto fue: " + precioMasAlto);
            Console.WriteLine("El precio mas bajo fue: " + precioMasBajo);
        }
    }
}