using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lib
{
    public class PizzaDecorator : Pizza
    {
        protected Pizza pizza;

        public PizzaDecorator(string name, Pizza p) : base(name)
        {
            this.pizza = p;
        }

        public override double getCost()
        {
            return pizza.getCost();
        }
    }
}
