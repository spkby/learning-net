using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{

    public struct Point
    {
        public double x;
        public double y;
    }

    public class Triangle
    {
        Point A { get; set; }
        Point B { get; set; }
        Point C { get; set; }

        public Triangle(Point A, Point B, Point C)
        {
            this.A = A;
            this.B = B;
            this.C = C;
        }

        public Triangle(double xA, double xB, double xC, double yA, double yB, double yC)
        {
            Point a, b, c;

            a.x = xA;
            a.y = xB;
            b.x = xC;
            b.y = yA;
            c.x = yB;
            c.y = yC;

            A = a;
            B = b;
            C = c;
        }

        public bool CheckExist()
        {
            if (lenAB() < (lenBC()+lenAC())
                && lenAC() < (lenBC() + lenAB())
                && lenBC() < (lenAC() + lenAB()))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        double lenAB()
        {
            return Math.Pow(Math.Pow(A.x - B.x, 2) + Math.Pow(A.y - B.y, 2), 0.5);
        }

        double lenBC()
        {
            return Math.Pow(Math.Pow(C.x - B.x, 2) + Math.Pow(C.y - B.y, 2), 0.5);
        }

        double lenAC()
        {
            return Math.Pow(Math.Pow(A.x - C.x, 2) + Math.Pow(A.y - C.y, 2), 0.5);
        }


        public double GetP()
        {
            return lenAB() + lenBC() + lenAC();
        }

        public double GetS()
        {
            double p = GetP() / 2;
            return Math.Sqrt(p * (p - lenAB()) * (p - lenAC()) * (p-lenBC()));
        }

    }



}
