using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaWithSousage : PizzaDecorator
    {
        public PizzaWithSousage(Pizza p) : base(p.name + " с сосисками", p)
        {
        }

        public override double getCost()
        {
            return base.getCost() + 3;
        }
    }
}
