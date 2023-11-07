using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberChecker
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrimeNumberChecker(5);
            Console.ReadLine();
        }

        public static void PrimeNumberChecker(int i)
        {
            int x = 1, counter = 0;
            for (int j = 0; j < i; j++)
            {
                if (i % x == 0)
                {
                    counter++;
                }
                x++;
            }


            if (counter == 2)
            {
                Console.WriteLine("To liczba pierwsza");
            }
            else
            {
                Console.WriteLine("To nie liczba pierwsza");
            }
        }
    }
}
