using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PodciagCiag
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = "word";

            podciag(word);
            //FindAllSubstring(word);

            Console.ReadLine();
        }

        public static void podciag(string word)
        {
            word = word.Remove(0,word.Length);
            Console.WriteLine(word);
        }

        private static void FindAllSubstring(string str)
        {
            for (int i = 0; i < str.Length; ++i)
            {
                StringBuilder subString = new StringBuilder(str.Length - i);

                for (int j = i; j < str.Length; ++j)
                {
                    subString.Append(str[j]);
                    Console.Write(subString + "\n");
                }


            }
        }
    }
}
