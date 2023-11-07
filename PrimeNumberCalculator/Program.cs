using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj znak: ");

            PrimeNumberCalculator primeNumberCalculator = new PrimeNumberCalculator();

            String Znak = Console.ReadLine();
            primeNumberCalculator.ZnakChecker(Znak);
            String Read1 = Console.ReadLine();
            String Read2 = Console.ReadLine();
            int NumberInt1 = 0;
            int NumberInt2 = 0;

            if (int.TryParse(Read1, out NumberInt1) && int.TryParse(Read2, out NumberInt2))
            {

            }
            else
            {
                Console.WriteLine("To nie sa liczby calkowite!");
            }

            primeNumberCalculator.PrimeNumberChecker(NumberInt1, NumberInt2);
            primeNumberCalculator.calculate(Znak, NumberInt1, NumberInt2);

            Console.ReadLine();

        }

        public class PrimeNumberCalculator
        {
            public void PrimeNumberChecker(int number1, int number2)
            {
                int counter1 = 0;
                int counter2 = 0;


                for (int i = 1; i <= number1; i++)
                {
                    if (number1 % i == 0) counter1++;
                }

                if (counter1 != 2)
                {
                    Console.WriteLine("Liczba1 nie jest liczbą pierwszą");
                }



                for (int i = 1; i <= number2; i++)
                {
                    if (number2 % i == 0) counter2++;
                }

                if (counter2 != 2)
                {
                    Console.WriteLine("Liczba2 nie jest liczbą pierwszą");
                }

            }

            public void ZnakChecker(string znak)
            {
                if (znak != "/" && znak != "*" && znak != "+" && znak != "-")
                {
                    Console.WriteLine("Błędny znak");
                }
            }

            public void calculate(string znak, int number1, int number2)
            {
                if (znak == "+")
                {
                    Console.WriteLine(number1 + number2);
                }

                if (znak == "-")
                {
                    Console.WriteLine(number1 - number2);
                }

                if (znak == "*")
                {
                    Console.WriteLine(number1 * number2);
                }

                if (znak == "/")
                {
                    Console.WriteLine(number1 / number2);
                }
            }
        }
    }
}
