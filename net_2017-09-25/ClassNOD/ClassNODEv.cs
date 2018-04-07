using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNOD
{
    public class ClassNODEv
    {
        public int NOD(int a, int b)
        {
            while (a != 0 && b != 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            return a + b;
        }

        public int NOD(int a, int b, int c)
        {
            while (a != 0 && b != 0 && c != 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else if (b >= c)
                {
                    b = b % a;
                }
                else
                {
                    c = c % b;
                }
            }

            if (a == 0)
            {
                a = b;
                b = c;
            }
            else if (b == 0) b = c;

            return NOD(a,b);
        }
        public int NOD(int a, int b, int c, int d)
        {
            while (a != 0 && b != 0 && c != 0 && d != 0)
            {
                if (a >= b)
                {
                    a = a % b;
                }
                else if (b >= c)
                {
                    b = b % a;
                }
                else if (c >= d)
                {
                    c = c % b;
                }
                else
                {
                    d = d % c;
                }
            }

            if (a == 0)
            {
                a = b;
                b = c;
                c = d;
            }
            else if (b == 0)
            {
                b = c;
                c = d;
            }
            else if (c == 0) c = d;          

            return NOD(a, b, c);
        }
    }
}
