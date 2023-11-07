using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace String_Reverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringReverse("polak");
            StringReverseList("polak");

            Console.ReadLine();
        }

        public static void StringReverse(string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0, j = chars.Length-1; i < j; i++, j--)
            {
                chars[i] = s[j];
                chars[j] = s[i];
            }
            string ReversedString = new string(chars);
            Console.WriteLine(ReversedString);
        }

        public static void StringReverseList(string s)
        {
            List<char> list = new List<char>();
            foreach (char c in s)
            {
                list.Add(c);
            }

            list.Reverse();

            foreach (char c in list)
            {
                Console.Write(c);
            }
        }
    }
}
