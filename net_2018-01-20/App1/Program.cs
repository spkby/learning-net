using System;
using System.Text.RegularExpressions;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hello World, World!!! ЁАЯЬЪЙ";

            Console.WriteLine(str.WordCount());
            Console.WriteLine(str.CapitalCount());
            Console.WriteLine(str.InvertString());

            Console.ReadLine();
        }
    }
    public static class StringExtension
    {
        public static int WordCount(this string str)
        {
            string[] strings = str.Split(' ');
            return strings.Length;
        }

        public static int CapitalCount(this string str)
        {
            Regex regex = new Regex(@"[А-ЯЁA-Z]");
            MatchCollection matches = regex.Matches(str);
            return matches.Count;
        }

        public static string InvertString(this string str)
        {
            string newStr = "";
            for (int i = str.Length-1; i >= 0; i--)
            {
                newStr += str.Substring(i,1);
            }

            return newStr;
        }
    }
}
