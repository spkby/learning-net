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
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();

            int x, y, z;

            x = Convert.ToInt32(firstNumber);
            y = Convert.ToInt32(secondNumber);
            z = x + y;

            Console.WriteLine("Sum {0} and {1} = {2}",x,y,z);

            Console.ReadKey();
        }
    }
}
