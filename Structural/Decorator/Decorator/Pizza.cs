namespace Decorator
{
    public abstract class Pizza
    {
        public string Name { get; }

        protected Pizza(string name)
        {
            Name = name;
        }

        public abstract int GetCost();
    }
}
