namespace Decorator
{
    public abstract class PizzaDecorator : Pizza
    {
        public Pizza Pizza { get; set; }

        protected PizzaDecorator(string name, Pizza pizza) : base(name)
        {
            Pizza = pizza;
        }
    }
}
