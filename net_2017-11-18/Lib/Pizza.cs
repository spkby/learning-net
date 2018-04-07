namespace Lib
{
    public abstract class Pizza
    {
        public string name { get; protected set; }

        public Pizza(string name)
        {
            this.name = name;
        }
        public abstract double getCost();
    }
}
