using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Cervera_ValorDouble
{
    class Program
    {
        static void Main(string[] args)
        {
            int ancho;
            int altura;

            Console.WriteLine("Escriba un valor para altura");
            altura = int.Parse(Console.ReadLine());
            Console.WriteLine("Escriba un valor para ancho");
            ancho = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado del perimetro es: " + (ancho * ancho + altura * altura));
            Console.WriteLine("El area es: " + (ancho*altura));
            Console.WriteLine("La diagonal es: " + (Math.Sqrt(altura * altura + ancho * ancho)));

            Console.ReadKey();
        }
    }
}
