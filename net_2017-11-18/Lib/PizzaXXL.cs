using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaXXL : PizzaDecorator
    {
        public PizzaXXL(Pizza p) : base(p.name +" XXL", p)
        {
        }
        public override double getCost()
        {
            return base.getCost() + 10;
        }
    }
}
