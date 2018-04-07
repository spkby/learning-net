using RegexSmpl;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputStr = "";

            inputStr = Console.ReadLine();

            Calculator calc = new Calculator();

            int result = 0;

            result = calc.calc(inputStr);

            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
