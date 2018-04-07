using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaLarge : PizzaDecorator
    {
        public PizzaLarge(Pizza p) : base(p.name + " большая", p)
        {
        }

        public override double getCost()
        {
            return base.getCost() + 6;
        }
    }
}
