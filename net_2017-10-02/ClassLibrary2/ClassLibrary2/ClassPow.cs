using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class ClassPow
    {
        public double calc(int pow, double number, double accuracy)
        {
            /*double result0 = number, result1=0;
            int i = 1;
            while(Math.Abs(result1 - result0) < accuracy)
            {
                result1 = 1 / (pow) * ((pow - 1) * i + number / (Math.Pow(i, pow-1)));
                i++;                
            }
            /

            /int pow = 2;
            double number = 25;*/

            double xi1 = 3,xi;

            do
            {
                xi = xi1;

                xi1 = (1 / pow) * ( ( (pow - 1) * xi1 ) + number / (Math.Pow(xi1, pow - 1) ) );
            }
            while (Math.Abs(xi - xi1) > accuracy);

            return xi1;

        }

    }
}
