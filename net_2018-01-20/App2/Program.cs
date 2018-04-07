using System;
using System.Collections.Generic;

namespace App2
{
    class Program
    {
        delegate int LambdaFunc(int x);
        delegate string LambdaFuncs(int x1,int x2, int delta);
        static void Main(string[] args)
        {
            int x1 = 1, x2 = 9, delta = 1;


            ClassFunc func = new ClassFunc();
            string str = "";
            func.Calc(x1, x2, delta);
            for (int i = 0; i < func.X.Length; i++)
            {
               str += func.X[i] + " ";
            }

            LambdaFunc lambda = (x) => x * x;

            LambdaFuncs lambdas = (lx1, lx2, ldelta) =>
            {
                List<int> lst = new List<int>();
                string lstr = "";
                for (int i = x1; i <= x2; i += delta)
                {
                    lstr += lambda(i) + " ";
                }
                return lstr;
            };

            Console.WriteLine(str);
            Console.WriteLine(lambdas(x1, x2, delta));
            Console.Read();
        }
    }
}
