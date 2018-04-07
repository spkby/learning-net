namespace Lib
{
    public class PizzaClassic : Pizza
    {
        public PizzaClassic() : base ("Классическя")
        { }

        public override double getCost()
        {
            return 10;
        }
    }
}
