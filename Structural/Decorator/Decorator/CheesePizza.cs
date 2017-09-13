namespace Decorator
{
    public class CheesePizza : PizzaDecorator
    {
        public CheesePizza(Pizza pizza) : base(pizza.Name + ", с сыром", pizza)
        {
        }

        public override int GetCost()
        {
            return Pizza.GetCost() + 5;
        }
    }
}
