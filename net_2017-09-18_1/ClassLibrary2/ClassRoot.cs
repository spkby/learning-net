using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary

{
    public class ClassRoot
    {
        public double root(double pow, double number, double accuracy)
        {
            var xi1 = number;
            var xi = number;

            do
            {
                xi = xi1;
                xi1 = (1 / pow) * (((pow - 1) * xi1) + number / (Math.Pow(xi1, pow - 1)));
            }
            while (Math.Abs(xi - xi1) > accuracy);

            return xi1;
        }

        public double chk(double pow, double number, double accuracy)
        {
            double rts = root(pow, number, accuracy);
            return Math.Abs(Math.Pow(rts,pow)-number);
        }


    }
}
