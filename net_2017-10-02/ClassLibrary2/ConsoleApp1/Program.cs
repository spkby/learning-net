using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ClassPow calc = new ClassPow();

            double aa = calc.calc(2,25,0.1);

            Console.WriteLine(aa);
        }
    }
}
