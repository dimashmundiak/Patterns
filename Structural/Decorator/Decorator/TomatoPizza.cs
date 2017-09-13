namespace Decorator
{
    public class TomatoPizza : PizzaDecorator
    {
        public TomatoPizza(Pizza pizza) : base(pizza.Name + ", с томатами", pizza)
        {
        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 3;
        }
    }
}
