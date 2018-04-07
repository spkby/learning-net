using System;
using ClassLibrary;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            double xA, xB, xC, yA, yB, yC;

            Random rnd = new Random();
            xA = rnd.Next();
            xB = rnd.Next();
            xC = rnd.Next();
            yA = rnd.Next();
            yB = rnd.Next();
            yC = rnd.Next();

            Console.WriteLine("xA: {0}, xB: {1}, xC: {2}", xA, xB, xC);
            Console.WriteLine("yA: {0}, yB: {1}, yC: {2}", yA, yB, yC);

            Triangle tr = new Triangle(xA, xB, xC, yA, yB, yC);

            if(tr.CheckExist())
            {
                Console.WriteLine("P: {0}, S: {1}", tr.GetP(), tr.GetS());
            }
            else
            {
                Console.WriteLine("Треугольника с такими вершинами не существует");
            }
            
            Console.ReadLine();
        }
    }
}
