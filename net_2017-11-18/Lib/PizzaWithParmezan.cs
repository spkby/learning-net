using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaWithParmezan : PizzaDecorator
    {
        public PizzaWithParmezan(Pizza p) : base(p.name + " с пармезаном", p)
        {
        }
        public override double getCost()
        {
            return base.getCost() + 3;
        }
    }
}
