using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Goods
    {
        public string goodName { set; get; }
        public double price { set; get; }

        public static double discount { get; set; }

        static Goods()
        {
            discount = 3;
        }

        public Goods(string goodName, double price)
        {
            this.goodName = goodName;
            this.price = price;
        }

        public static double getDiscount(Goods good)
        {
            return good.price * discount / 100;
        }

        public static Goods operator +(Goods good1, Goods good2)
        {
            return new Goods("Basket",good1.price + good2.price);
        }

        public override string ToString()
        {
            return "Name: " + goodName + " price: " + price.ToString();
        }

    }
}
