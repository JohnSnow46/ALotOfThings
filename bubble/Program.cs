using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bubble123
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> Numbers = new List<int> {3,2,1,3,2,14,4,3,124};

            BubbleSort(Numbers);

            foreach (int num in Numbers) { Console.Write(num+" "); }

            List<Auto> autos = new List<Auto>
            {
                new Auto{Name = "ford", Horses = 123},
                new Auto{Name = "ferrari", Horses = 432},
                new Auto{Name = "porsche", Horses = 121},
                new Auto{Name = "opel", Horses = 111}
            };

            var SortedByHorses = autos.OrderBy(x => x.Horses);
            Console.WriteLine();
            foreach (var auto in SortedByHorses) { Console.WriteLine(auto.Name+" "+auto.Horses); }

            Console.ReadLine();
        }

        static void BubbleSort(List<int> numbers)
        {
            for(int j=0; j<numbers.Count-1; j++)
            {
                for (int i = 0; i < numbers.Count - 1; i++)
                {
                    if (numbers[i] > numbers[i + 1])
                    {
                        int swap = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = swap;
                    }
                }
            }
        }

        public class Auto
        {
            public String Name { get; set; }
            public int Horses { get; set; } 
        }

    }
}
