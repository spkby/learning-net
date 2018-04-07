using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaColsone : Pizza
    {
        public PizzaColsone() : base("Кользоне") { }
        public override double getCost()
        {
            return 13;
        }
    }
}
