using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Cervera_TestVariable
{
    class Program
    {
        static void Main(string[] args)
        {
            int entero;
            bool boolean;
            float flotante;
            Double doble;
            Char caracter;
            String cadena;

            caracter = '1';
            cadena = "15.55794";
            entero = 15;
            boolean = false;
            flotante = 15.557294f;
            doble = 15.557294;

            Console.WriteLine("String: " + cadena);
            Console.WriteLine("int: " + entero);
            Console.WriteLine("bool: " + boolean);
            Console.WriteLine("float: " + flotante);
            Console.WriteLine("Char: " + caracter);
            Console.WriteLine("Double: " + doble);
            entero = int.Parse(Console.ReadLine());//NO PONER LETRA
            Console.ReadKey();

        }
    }
}
