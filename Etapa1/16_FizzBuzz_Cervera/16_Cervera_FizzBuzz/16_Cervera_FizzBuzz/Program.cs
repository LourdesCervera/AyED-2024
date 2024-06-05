using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16_Cervera_FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int fb = 1; fb <= 100; fb++)
            {
                if (fb % 3 == 0 && fb % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (fb % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (fb % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(fb);
                }
            }

            Console.ReadLine();
        }
       }
    }


