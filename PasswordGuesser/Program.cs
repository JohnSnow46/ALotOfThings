using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PasswordGuesser
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String[] listwords = new string[10];
            {
                listwords[0] = "królik";
                listwords[1] = "marchewka";
                listwords[2] = "komputer";
                listwords[3] = "lodówka";
                listwords[4] = "telewizor";
                listwords[5] = "samochód";
                listwords[6] = "drzewo";
                listwords[7] = "jabłko";
                listwords[8] = "melon";
                listwords[9] = "krzesło";
            }

            Random rand = new Random();
            var idx = rand.Next(0, 9);

            PasswordGuesser(listwords[idx]);

            Console.ReadLine();
        }

        public static void PasswordGuesser(String password)
        {
            //Console.WriteLine(password);
            List<char> ListaZnakow = password.ToList();
            List<char> ListZnakowZgadywanie = new List<char>();

            char znak;
            int counter = 0;
            while (ListaZnakow != ListZnakowZgadywanie)
            {
                String ReadZnak = Console.ReadLine();
                znak = ReadZnak[0];
                if (ReadZnak.Count() != 1)
                {

                    Console.WriteLine("Wrong input");

                }
                else
                {
                    if (znak == ListaZnakow[counter])
                    {
                        ListZnakowZgadywanie.Add(znak);
                        counter++;
                    }

                    foreach (char c in ListZnakowZgadywanie)
                    {
                        Console.Write(c);
                    }
                }
            }

            Console.WriteLine();
        }
    }
}
