using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lib;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {

            Pizza p1 = new PizzaColsone();
            p1 = new PizzaLarge(p1);
            p1 = new PizzaWithMozarella(p1);
            p1 = new PizzaWithSousage(p1);

            Pizza p2 = new PizzaPrimavera();
            p2 = new PizzaSmall(p2);
            p2 = new PizzaWithParmezan(p2);
            p2 = new PizzaWithSpam(p2);


            Pizza p3 = new PizzaClassic();
            p3 = new PizzaXXL(p3);
            p3 = new PizzaWithMozarella(p3);
            p3 = new PizzaWithSalami(p3);


            Pizza p4 = new PizzaClassic();
            p4 = new PizzaWithMozarella(new PizzaWithSousage(new PizzaLarge(p4)));


            Console.WriteLine("Название: {0}\tСтоимость: {1}", p1.name, p1.getCost());
            Console.WriteLine("Название: {0}\tСтоимость: {1}", p2.name, p2.getCost());
            Console.WriteLine("Название: {0}\tСтоимость: {1}", p3.name, p3.getCost());
            Console.WriteLine("Название: {0}\tСтоимость: {1}", p4.name, p4.getCost());

            Console.ReadLine();



        }
    }
}
