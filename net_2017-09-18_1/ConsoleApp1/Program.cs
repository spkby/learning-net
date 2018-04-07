using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoot root = new ClassRoot();
            Console.WriteLine("enter number");
            double number = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("enter pow");
            double pow = Convert.ToDouble(Console.ReadLine().Replace(".", ","));
            Console.WriteLine("enter accuracy");
            double accuracy = Convert.ToDouble(Console.ReadLine().Replace(".", ","));

            double rt = root.root(pow, number, accuracy);
            Console.WriteLine(rt);
            double chk = root.chk(pow, number, accuracy);
            Console.WriteLine(chk);
            Console.ReadLine();
        }
    }
}
