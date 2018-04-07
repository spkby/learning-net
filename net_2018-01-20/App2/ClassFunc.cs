using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App2
{
    class ClassFunc
    {
        public int[] X { get; set; }

        public void Calc(int x1, int x2, int delta)
        {
            List<int> lst = new List<int>();
            for (int i = x1; i <= x2; i += delta)
            {
                lst.Add(Func(i));
            }
            X = lst.ToArray();
        }

        public int Func(int x)
        {
            return x * x;
        }

    }
}
