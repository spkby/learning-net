using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaSmall : PizzaDecorator
    {
        public PizzaSmall(Pizza p) : base(p.name +" маленькая", p)
        {
        }

        public override double getCost()
        {
            return base.getCost() - 3;
        }

    }
}
