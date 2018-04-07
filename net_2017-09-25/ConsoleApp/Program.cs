using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassNOD;

namespace ConsoleApp
{
    class Program
    {
        static Random rnd = new Random();
        static int a, b, c, d;

        static void Rnd()
        {
            a = rnd.Next(1, 10);
            b = rnd.Next(1, 10);
            c = rnd.Next(1, 10);
            d = rnd.Next(1, 10);
        }

        static void Main(string[] args)
        {
            Rnd();
            ClassNODEv nodE = new ClassNODEv();
            Console.WriteLine(nodE.NOD(a,b,c,d));

            Rnd();
            ClassNODSt nodS = new ClassNODSt();
            Console.WriteLine(nodS.NOD(a, b));

            Console.ReadLine();
        }
    }
}
