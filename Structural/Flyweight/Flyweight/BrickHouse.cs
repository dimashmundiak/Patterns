using System;

namespace Flyweight
{
    public class BrickHouse : House
    {
        public BrickHouse()
        {
            stages = 6;
        }

        public override void Build(double longitude, double latitude)
        {
            Console.WriteLine($"Построен кирпичный дом из 5 этажей; координаты: {latitude} широты и {longitude} долготы");
        }
    }
}
