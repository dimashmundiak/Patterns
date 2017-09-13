using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Pizza pizza1 = new ItalianPizza();
            pizza1 = new TomatoPizza(pizza1);
            Console.WriteLine($"Название: {pizza1.Name}");
            Console.WriteLine($"Цена: {pizza1.GetCost()}");

            Pizza pizza2 = new ItalianPizza();
            pizza2 = new CheesePizza(pizza2);
            Console.WriteLine($"Название: {pizza2.Name}");
            Console.WriteLine($"Цена: {pizza2.GetCost()}");

            Pizza pizza3 = new BulgerianPizza();
            pizza3 = new TomatoPizza(pizza3);
            pizza3 = new CheesePizza(pizza3);
            Console.WriteLine($"Название: {pizza3.Name}");
            Console.WriteLine($"Цена: {pizza3.GetCost()}");

            Console.ReadLine();
        }
    }
}
