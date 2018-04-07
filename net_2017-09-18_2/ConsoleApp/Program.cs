using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassDecToBin dtb = new ClassDecToBin();
            Console.WriteLine("enter digits");
            string str = Console.ReadLine();

            str = dtb.digitsDecToBin(str);

            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
