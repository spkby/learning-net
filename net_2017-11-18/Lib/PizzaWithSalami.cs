using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaWithSalami : PizzaDecorator
    {
        public PizzaWithSalami(Pizza p) : base(p.name + " с колбасой", p)
        {
        }

        public override double getCost()
        {
            return base.getCost() + 5;
        }        
    }
}
