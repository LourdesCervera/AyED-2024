﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Cervera_TablaDeMultipl
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero: ");
            num = int.Parse(Console.ReadLine());
            Console.WriteLine(num + " * 1= " + (num * 1));
            Console.WriteLine(num + " * 2= " + (num * 2));
            Console.WriteLine(num + " * 3= " + (num * 3));
            Console.WriteLine(num + " * 4= " + (num * 4));
            Console.WriteLine(num + " * 5= " + (num * 5));
            Console.WriteLine(num + " * 6= " + (num * 6));
            Console.WriteLine(num + " * 7= " + (num * 7));
            Console.WriteLine(num + " * 8= " + (num * 8));
            Console.WriteLine(num + " * 9= " + (num * 9));
            Console.WriteLine(num + " * 10= " + (num * 10));
            Console.ReadKey();
        }
    }
}
