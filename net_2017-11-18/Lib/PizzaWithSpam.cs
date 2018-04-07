using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaWithSpam : PizzaDecorator
    {
        public PizzaWithSpam(Pizza p) : base(p.name + " c ветчиной", p)
        {
        }

        public override double getCost()
        {
            return base.getCost() + 4;
        }
    }
}
