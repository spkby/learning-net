using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaWithMozarella : PizzaDecorator
    {
        public PizzaWithMozarella(Pizza p) : base(p.name + " с моцареллой", p)
        {
        }
        public override double getCost()
        {
            return base.getCost() + 4;
        }
    }
}
