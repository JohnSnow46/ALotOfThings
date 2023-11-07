using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqLambda
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 5, 3, 6, 7, 2, 3, 1, 6, 7 };

            var linqEnum = list.Where(n => n % 2 == 0).OrderBy(n => n);//zamienic order z where lepiej
            foreach (int n in linqEnum) { Console.WriteLine(n); }

            var ObiektCollection = new List<Person>
            {
                new Person{ Name = "Andrzej", DateOfBirth = new DateTime(2000,11,8)},
                new Person{ Name = "Grzegorz", DateOfBirth = new DateTime(1998,03,2)},
                new Person{ Name = "Franek", DateOfBirth = new DateTime(1967,12,1)},
                new Person{ Name = "Janusz", DateOfBirth = new DateTime(2006,11,10)},
            };

            DateTime eighteenYearsAgo = DateTime.Now.AddYears(-18);

            var AdultChecker = ObiektCollection.Where(d => d.DateOfBirth <= eighteenYearsAgo).ToList();

            foreach (var x in AdultChecker) { Console.WriteLine(x.Name + " " + x.DateOfBirth); }

            var ProductList = new List<Products>
            {
                new Products{Name="Frytki",Price=20.99M},
                new Products{Name="Ziemniaki",Price=11.99M},
                new Products{Name="Placki",Price=43.99M},
                new Products{Name="Kluski",Price=51.99M}
            };

            var MaxPrice = ProductList.Max(p => p.Price);

            //List<int> list = new List<int> { 5, 3, 6, 7, 2, 3, 1, 6, 7 };
            var SumThree = list.Where(p => p % 3 == 0).Sum();
            var AvgEven = list.Where(p => p % 2 == 0).Average();
            Console.WriteLine(SumThree);
            Console.WriteLine(AvgEven);

            var GroupByName = ProductList.GroupBy(p => p.Name);
            foreach (var x in GroupByName) 
            {
            
            }

            //Console.WriteLine(MaxPrice);

            Console.Read();
        }
    }
}
