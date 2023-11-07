using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTranspose
{
    internal class Program
    {
        static Random _random = new Random();
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 23, 4, 5, 6, 778, 9 };

            var evenNumbers = Enumerable.Where(list, n => n % 2 == 0);

            foreach (var n in evenNumbers) { Console.WriteLine(n); }

            var array = new int[][] { new int[]{ 1, 2 ,3 ,4 },
                new int[]{ 1, 2, 3, 4  },
                new int[]{ 1, 2, 3, 4  },
                new int[]{ 1, 2, 3, 4 }

            };

            var transposedArray = Enumerable.Range(0, array.Length).Select(x => array.Select(y => y[x]));

            foreach (var row in transposedArray)
            {
                foreach (var number in row)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }

            

            List<int> newList = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            var even = newList.Where(x => x % 2 == 0);

            //foreach(var number in even) { Console.Write(number + " "); }

            var suggestedNumbers = newList.Where(n => n > 3).OrderBy(n=>_random.Next()).Take(2);
            foreach (var n in suggestedNumbers) {  Console.WriteLine(n); }


            Console.ReadLine();
        }     
    }
}
