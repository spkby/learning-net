using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaPrimavera : Pizza
    {
        public PizzaPrimavera() : base("Примавера") { }

        public override double getCost()
        {
            return 15;
        }
    }
}
