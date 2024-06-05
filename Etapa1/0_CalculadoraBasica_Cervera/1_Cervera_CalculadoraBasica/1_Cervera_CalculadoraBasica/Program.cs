using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Cervera_CalculadoraBasica
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa en C# que calcule el resultado de
            sumar, restar, multiplicar y dividir dos números
            introducidos por el usuario.
            Además también debería calcular el resto de la división
            en la última linea.
            */

            int num1;
            int num2;

            Console.WriteLine("Ingrese un numero");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Multiplicado: " + num1*num2);
            Console.WriteLine("Sumado: " + (num1 + num2));
            Console.WriteLine("Restado: " + (num1 - num2));
            Console.WriteLine("Dividido: " + num1 / num2);
            Console.WriteLine("El resto del dividido: " + num1 % num2);
            Console.ReadKey();
        }
    }
}
