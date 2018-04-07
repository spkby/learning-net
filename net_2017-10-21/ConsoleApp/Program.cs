using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Goods apple = new Goods("Apple", 100);
            Goods orange = new Goods("Orange", 300);

            Console.WriteLine(apple + orange);
            Console.WriteLine(Goods.getDiscount(apple));
            Console.WriteLine(Goods.getDiscount(orange));

            Console.ReadLine();
        }
    }
}
